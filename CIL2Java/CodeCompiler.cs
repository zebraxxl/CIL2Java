using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private IResolver resolver;
        private INamesController namesController;
        private IByRefController byRefController;
        private InterMethod thisMethod;
        private JavaBytecodeWriter codeGenerator = new JavaBytecodeWriter();
        private JavaBytecodeWriter oldCodeGenerator = null;
        private Java.ConstantPool constsPool;
        private Java.Attributes.Code resultCode = null;
        private Random rnd = new Random();
        private ILBlock ilBody;
        private Stack<string> loopOrSwitchExitLabel = new Stack<string>();

        public Java.Attributes.Code Result { get { return resultCode; } }

        public CodeCompiler(IResolver resolver, INamesController namesController, IByRefController byRefController,
            InterMethod method,Java.ConstantPool constsPool)
        {
            this.resolver = resolver;
            this.namesController = namesController;
            this.byRefController = byRefController;
            this.thisMethod = method;
            this.constsPool = constsPool;
        }

        public void Compile()
        {
            MethodDefinition methodDef = thisMethod.Body.Method;

            Messages.Verbose("      Generating IL graph...");

            ILAstBuilder builder = new ILAstBuilder();
            ilBody = new ILBlock();

            DecompilerContext context = new DecompilerContext(methodDef.Module) { CurrentType = methodDef.DeclaringType, CurrentMethod = methodDef };
            Utils.SetDecompillerSettings(context.Settings);

            ilBody.Body = builder.Build(methodDef, true, context);
            new ILAstOptimizer().Optimize(context, ilBody);

            FillVars(builder.Parameters);

            Messages.Verbose("      Preprocess IL graph...");
            RunPreprocessor();

            Messages.Verbose("      Compiling IL graph to java bytecode...");
            CompileNode(ilBody, ExpectType.None);

            //Checking for deleted last ret
            if (ilBody.Body.Count > 0)
            {
                ILNode lastNode = ilBody.Body.Last();
                if ((lastNode is ILExpression) && (((ILExpression)lastNode).Code != ILCode.Ret) &&
                    (((ILExpression)lastNode).Code != ILCode.Throw))
                    CompileRet(null, ExpectType.None);
                else if (thisMethod.ReturnParameter.Type.PrimitiveType == PrimitiveType.Void)
                    CompileRet(null, ExpectType.None);
            }
            else
                CompileRet(null, ExpectType.None);

            Messages.Verbose("      Linking java bytecode...");
            byte[] codeBytes = codeGenerator.Link(constsPool);
            GenerateJavaExceptionTable();

            oldCodeGenerator = codeGenerator;
            byte[] prolog = GenerateMethodProlog();

            resultCode = new Java.Attributes.Code();
            resultCode.CodeBytes = prolog.Concat(codeBytes).ToArray();

            WriteJavaExceptionTable(prolog.Length);

            Messages.Verbose("      Simulating stack to calculate MaxStack and MaxLocals...");
            StackSimulator.SimulateStack(constsPool, resultCode);
            resultCode.MaxLocals = (ushort)nextVarIndex;

            if (Program.Debug)
                GenerateDebugInfo(prolog.Length);
        }

        private void CompileNode(ILNode node, ExpectType expectType)
        {
            bool unknownNode = false;

            if (node is ILBlock)
                CompileBlock((ILBlock)node);
            else if (node is ILExpression)
                CompileExpression((ILExpression)node, expectType);
            else if (node is ILCondition)
                CompileCondition((ILCondition)node, expectType);
            else if (node is ILTryCatchBlock)
                CompileTryBlock((ILTryCatchBlock)node);
            else if (node is ILWhileLoop)
                CompileLoop((ILWhileLoop)node);
            else if (node is ILLabel)
                codeGenerator.Label(((ILLabel)node).Name);
            else if (node is ILSwitch)
                CompileSwitch((ILSwitch)node);
            else
                unknownNode = true;

            if (unknownNode)
                Messages.Message(MessageCode.UnknownNode, node.ToString());
        }

        private void CompileSwitch(ILSwitch node)
        {
            CompileExpression(node.Condition, ExpectType.Primitive);  //TODO: Switch on long

            JavaBytecodeWriter.LookupswitchOperand operand = new JavaBytecodeWriter.LookupswitchOperand();

            JavaInstruction switchInstr = new JavaInstruction(Java.OpCodes.lookupswitch, null, node);
            codeGenerator.AddInstruction(switchInstr);

            string labelsSufix = rnd.Next().ToString();
            string defaultLabel = "default" + labelsSufix;
            string exitLabel = "exit" + labelsSufix;
            bool wasDefault = false;
            List<Tuple<int, string>> pairs = new List<Tuple<int, string>>();

            loopOrSwitchExitLabel.Push(exitLabel);
            int index = 0;
            foreach (ILSwitch.CaseBlock caseBlock in node.CaseBlocks)
            {
                if (caseBlock.Values == null)
                {
                    codeGenerator.Label(defaultLabel);
                    wasDefault = true;
                }
                else
                {
                    string thisCaseLabel = "case" + (index++) + labelsSufix;
                    foreach (int val in caseBlock.Values)
                        pairs.Add(new Tuple<int, string>(val, thisCaseLabel));
                    codeGenerator.Label(thisCaseLabel);
                }

                CompileBlock(caseBlock);
            }
            loopOrSwitchExitLabel.Pop();

            if (!wasDefault)
                codeGenerator.Label(defaultLabel);
            codeGenerator.Label(exitLabel);

            pairs.Sort((T1, T2) => (T1.Item1 < T2.Item1 ? -1 : T1.Item1 > T2.Item1 ? 1 : 0));

            operand.DefaultLabel = defaultLabel;
            operand.Pairs = pairs.ToArray();
            switchInstr.Operand = operand;
        }

        private void CompileLoop(ILWhileLoop node)
        {
            string labelsSufix = rnd.Next().ToString();

            string loopLabel = "loop" + labelsSufix;
            string exitLabel = "exit" + labelsSufix;

            codeGenerator.Label(loopLabel);

            if (node.Condition != null)
            {
                CompileExpression(node.Condition, ExpectType.Primitive);
                codeGenerator.Add(Java.OpCodes.ifeq, exitLabel, node);  //goto to `exit` if Condition == 0
            }

            loopOrSwitchExitLabel.Push(exitLabel);
            CompileBlock(node.BodyBlock);
            loopOrSwitchExitLabel.Pop();

            codeGenerator
                .Add(Java.OpCodes._goto, loopLabel)
                .Label(exitLabel);
        }

        private void CompileCondition(ILCondition node, ExpectType expectType)
        {
            string labelsSufix = rnd.Next().ToString();
            string falseLabel = "false" + labelsSufix;
            string exitLabel = "exit" + labelsSufix;

            if (node.FalseBlock.Body.Count == 0)
                falseLabel = exitLabel;
            CompileCondition(new ILExpression(ILCode.LogicNot, null, node.Condition), falseLabel);

            //CompileExpression(node.Condition, ExpectType.Primitive);

            //Java.OpCodes branchInstr = Java.OpCodes.ifeq;
            //TranslateToBool(node.Condition.InferredType, ref branchInstr, node);

            //codeGenerator.Add(branchInstr, falseLabel, node);
            CompileBlock(node.TrueBlock, expectType);

            if (node.FalseBlock.Body.Count > 0)
            {
                codeGenerator.Add(Java.OpCodes._goto, exitLabel, node)
                    .Label(falseLabel);
                CompileBlock(node.FalseBlock, expectType);
            }

            codeGenerator.Label(exitLabel);
        }

        private void CompileExpression(ILExpression e, ExpectType expectType)
        {
            bool unknownNode = false;

            switch (e.Code)
            {
                //Consts
                case ILCode.Ldstr: CompileLdstr(e, expectType); break;
                case ILCode.Ldc_I4: CompileLdcI4(e, expectType); break;
                case ILCode.Ldc_I8: CompileLdcI8(e, expectType); break;
                case ILCode.Ldc_R4: CompileLdcR4(e, expectType); break;
                case ILCode.Ldc_R8: CompileLdcR8(e, expectType); break;
                case ILCode.Ldnull: CompileLdnull(e, expectType); break;
                case ILCode.DefaultValue: CompileDefaultValue(e, expectType); break;

                //Vars
                case ILCode.Ldloc: CompileLdloc(e, expectType); break;
                case ILCode.Stloc: CompileStloc(e, expectType); break;

                //Fields
                case ILCode.Stfld: CompileStfld(e, expectType); break;
                case ILCode.Stsfld: CompileStfld(e, expectType); break;
                case ILCode.Ldfld: CompileLdfld(e, expectType); break;
                case ILCode.Ldsfld: CompileLdfld(e, expectType); break;

                //Calls
                case ILCode.Call: CompileCall(e, expectType); break;
                case ILCode.Callvirt: CompileCall(e, expectType); break;
                case ILCode.CallGetter: CompileCall(e, expectType); break;
                case ILCode.CallSetter: CompileCall(e, expectType); break;
                case ILCode.CallvirtGetter: CompileCall(e, expectType); break;
                case ILCode.CallvirtSetter: CompileCall(e, expectType); break;
                //case ILCode.Calli: CompileCalli(e, expectType); break;    //TODO: opcode `calli`
                case ILCode.Ret: CompileRet(e, expectType); break;
                case ILCode.Jmp: CompileJmp(e, expectType); break;

                //ByRef
                case ILCode.Ldloca: CompileLdloca(e, expectType); break;
                case ILCode.Ldflda: CompileLdflda(e, expectType); break;
                case ILCode.Ldsflda: CompileLdflda(e, expectType); break;
                case ILCode.Ldelema: CompileLdelema(e, expectType); break;
                case ILCode.AddressOf: CompileAddressOf(e, expectType); break;
                case ILCode.Ldind_Ref: CompileLdind(e, expectType); break;
                case ILCode.Stind_Ref: CompileStind(e, expectType); break;

                //Objects
                case ILCode.Castclass: CompileCastclass(e, expectType); break;
                case ILCode.Newobj: CompileNewobj(e, expectType); break;
                case ILCode.Stobj: CompileStobj(e, expectType); break;
                case ILCode.Ldobj: CompileLdobj(e, expectType); break;
                case ILCode.Cpobj: CompileCpobj(e, expectType); break;
                case ILCode.Isinst: CompileIsinst(e, expectType); break;
                case ILCode.Box: CompileBox(e, expectType); break;
                case ILCode.Unbox: CompileUnbox(e, expectType); break;
                case ILCode.Unbox_Any: CompileUnbox_Any(e, expectType); break;

                //Arrays
                case ILCode.Newarr: CompileNewarr(e, expectType); break;
                case ILCode.InitArray: CompileNewarr(e, expectType); break;
                case ILCode.Stelem_Any: CompileStelem(e, expectType); break;
                case ILCode.Stelem_I1: CompileStelem(e, expectType); break;
                case ILCode.Stelem_I2: CompileStelem(e, expectType); break;
                case ILCode.Stelem_I4: CompileStelem(e, expectType); break;
                case ILCode.Stelem_I8: CompileStelem(e, expectType); break;
                case ILCode.Stelem_R4: CompileStelem(e, expectType); break;
                case ILCode.Stelem_R8: CompileStelem(e, expectType); break;
                case ILCode.Stelem_Ref: CompileStelem(e, expectType); break;
                case ILCode.Ldelem_Any: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_I: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_I1: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_I2: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_I4: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_I8: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_R4: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_R8: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_Ref: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_U1: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_U2: CompileLdelem(e, expectType); break;
                case ILCode.Ldelem_U4: CompileLdelem(e, expectType); break;
                case ILCode.Ldlen: CompileLdlen(e, expectType); break;

                //Exceptions
                case ILCode.Throw: CompileThrow(e, expectType); break;

                //Logic
                case ILCode.LogicNot: CompileLogicNot(e, expectType); break;
                case ILCode.LogicAnd: CompileLogicAnd(e, expectType); break;
                case ILCode.LogicOr: CompileLogicOr(e, expectType); break;
                case ILCode.TernaryOp: CompileTernaryOp(e, expectType); break;
                case ILCode.NullCoalescing: CompileNullCoalescing(e, expectType); break;

                case ILCode.__Brfalse: CompileBrfalse(e, expectType); break;
                case ILCode.Brtrue: CompileBrtrue(e, expectType); break;
                case ILCode.__Beq: CompileBeq(e, expectType); break;
                case ILCode.__Bge: CompileBge(e, expectType); break;
                case ILCode.__Bgt: CompileBgt(e, expectType); break;
                case ILCode.__Ble: CompileBle(e, expectType); break;
                case ILCode.__Blt: CompileBlt(e, expectType); break;
                case ILCode.__Bne_Un: CompileBneUn(e, expectType); break;
                case ILCode.__Bge_Un: CompileBgeUn(e, expectType); break;
                case ILCode.__Bgt_Un: CompileBgtUn(e, expectType); break;
                case ILCode.__Ble_Un: CompileBleUn(e, expectType); break;
                case ILCode.__Blt_Un: CompileBltUn(e, expectType); break;
                case ILCode.Ceq: CompileCeq(e, expectType); break;
                case ILCode.Cne: CompileCne(e, expectType); break;
                case ILCode.Cle: CompileCle(e, expectType); break;
                case ILCode.Clt: CompileClt(e, expectType); break;
                case ILCode.Cge: CompileCge(e, expectType); break;
                case ILCode.Cgt: CompileCgt(e, expectType); break;
                case ILCode.Cle_Un: CompileCle_Un(e, expectType); break;

                //Conv
                case ILCode.Conv_I1: 
                case ILCode.Conv_Ovf_I1:
                case ILCode.Conv_Ovf_I1_Un:
                case ILCode.Conv_Ovf_U1:
                case ILCode.Conv_Ovf_U1_Un:
                case ILCode.Conv_U1:
                    CompileConvTo1(e, expectType); break;

                case ILCode.Conv_I2:
                case ILCode.Conv_Ovf_I2:
                case ILCode.Conv_Ovf_I2_Un:
                case ILCode.Conv_Ovf_U2:
                case ILCode.Conv_Ovf_U2_Un:
                case ILCode.Conv_U2:
                    CompileConvTo2(e, expectType); break;

                case ILCode.Conv_I4:
                case ILCode.Conv_Ovf_I4:
                case ILCode.Conv_Ovf_I4_Un:
                case ILCode.Conv_Ovf_U4:
                case ILCode.Conv_Ovf_U4_Un:
                case ILCode.Conv_U4:
                    CompileConvTo4(e, expectType); break;

                case ILCode.Conv_I8:
                case ILCode.Conv_Ovf_I8:
                case ILCode.Conv_Ovf_I8_Un:
                case ILCode.Conv_Ovf_U8:
                case ILCode.Conv_Ovf_U8_Un:
                case ILCode.Conv_U8:
                    CompileConvTo8(e, expectType); break;

                case ILCode.Conv_I:
                case ILCode.Conv_Ovf_I:
                case ILCode.Conv_Ovf_I_Un:
                case ILCode.Conv_Ovf_U:
                case ILCode.Conv_Ovf_U_Un:
                case ILCode.Conv_U:
                    CompileConvToNative(e, expectType); break;

                case ILCode.Conv_R_Un: CompileConvRUn(e, expectType); break;

                //Math
                case ILCode.PostIncrement: CompilePostIncrement(e, expectType); break;
                case ILCode.Add: CompileAdd(e, expectType); break;
                case ILCode.Sub: CompileSub(e, expectType); break;
                case ILCode.Mul: CompileMul(e, expectType); break;
                case ILCode.Div: CompileDiv(e, expectType); break;
                case ILCode.Div_Un: CompileDivUn(e, expectType); break;
                case ILCode.Rem: CompileRem(e, expectType); break;
                case ILCode.Rem_Un: CompileRemUn(e, expectType); break;
                case ILCode.And: CompileAnd(e, expectType); break;
                case ILCode.Or: CompileOr(e, expectType); break;
                case ILCode.Xor: CompileXor(e, expectType); break;
                case ILCode.Shl: CompileShl(e, expectType); break;
                case ILCode.Shr: CompileShr(e, expectType); break;
                case ILCode.Shr_Un: CompileShrUn(e, expectType); break;
                case ILCode.Neg: CompileNeg(e, expectType); break;
                case ILCode.Not: CompileNot(e, expectType); break;

                //Delegates
                case ILCode.Ldftn: CompileLdftn(e, expectType); break;

                //Other
                case ILCode.LoopOrSwitchBreak: CompileLoopOrSwitchBreak(e, expectType); break;
                case ILCode.Br: CompileBr(e, expectType); break;
                case ILCode.Break: CompileBreak(e, expectType); break;
                case ILCode.Nop: CompileNop(e, expectType); break;
                //case ILCode.Dup: case ILCode.Pop: break;  //dup and pop should be removed by ILSpy

                default: unknownNode = true; break;
            }

            if (unknownNode)
                Messages.Message(MessageCode.UnknownNode, e.ToString());
            else if ((e.InferredType != null) && (e.ExpectedType != null))
            {
                InterType inferred = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
                InterType expected = resolver.Resolve(e.ExpectedType, thisMethod.FullGenericArguments);

                if ((expected.IsInterface) && (inferred.Interfaces.Where(T => T.Fullname == expected.Fullname).Count() == 0) &&
                    (inferred.InterfacesMap != null))
                {
                    InterType ifaceMap = inferred.InterfacesMap;

                    codeGenerator.Add(OpCodes.invokestatic, new MethodRef(
                        namesController.TypeNameToJava(ifaceMap),
                        ClassNames.InterfacesMapGetAdapterMethodName,
                        "(" + namesController.GetFieldDescriptor(inferred) + ")" + namesController.GetFieldDescriptor(ifaceMap)), e);
                }
            }
        }

        private void CompileBlock(ILBlock block, ExpectType expect)
        {
            foreach (ILNode node in block.Body)
                CompileNode(node, expect);
        }

        private void CompileBlock(ILBlock block)
        {
            CompileBlock(block, ExpectType.None);
        }
    }
}
