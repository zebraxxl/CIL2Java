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
        private InterMethod thisMethod;
        private JavaBytecodeWriter codeGenerator = new JavaBytecodeWriter();
        private Java.ConstantPool constsPool;
        private Java.Attributes.Code resultCode = null;

        public Java.Attributes.Code Result { get { return resultCode; } }

        public CodeCompiler(IResolver resolver, INamesController namesController, InterMethod method, Java.ConstantPool constsPool)
        {
            this.resolver = resolver;
            this.namesController = namesController;
            this.thisMethod = method;
            this.constsPool = constsPool;
        }

        public void Compile()
        {
            MethodDefinition methodDef = thisMethod.Body.Method;

            Messages.Verbose("      Generating IL graph...");

            ILAstBuilder builder = new ILAstBuilder();
            ILBlock ilBody = new ILBlock();

            DecompilerContext context = new DecompilerContext(methodDef.Module) { CurrentType = methodDef.DeclaringType, CurrentMethod = methodDef };

            ilBody.Body = builder.Build(methodDef, true, context);
            new ILAstOptimizer().Optimize(context, ilBody);

            FillVars(builder.Parameters);

            Messages.Verbose("      Compiling IL graph to java bytecode...");
            CompileNode(ilBody, ExpectType.None);

            //Checking for deleted last ret
            ILNode lastNode = ilBody.Body.Last();
            if ((lastNode is ILExpression) && (((ILExpression)lastNode).Code != ILCode.Ret))
                CompileRet(null, ExpectType.None);

            Messages.Verbose("      Linking java bytecode...");
            byte[] codeBytes = codeGenerator.Link(constsPool);

            resultCode = new Java.Attributes.Code();
            resultCode.CodeBytes = codeBytes;
            resultCode.MaxLocals = (ushort)nextVarIndex;

            Messages.Verbose("      Simulating stack to calculate MaxStack...");
            SimulateStack(constsPool);
        }

        private void CompileNode(ILNode node, ExpectType expectType)
        {
            bool unknownNode = false;

            if (node is ILBlock)
                CompileBlock((ILBlock)node);
            else if (node is ILExpression)
                CompileExpression((ILExpression)node, expectType);
            else
                unknownNode = true;

            if (unknownNode)
                Messages.Message(MessageCode.UnknownNode, node.ToString());
        }

        private void CompileExpression(ILExpression e, ExpectType expectType)
        {
            bool unknownNode = false;

            switch (e.Code)
            {
                //Consts
                case ILCode.Ldstr: CompileLdstr(e, expectType); break;
                case ILCode.Ldc_R4: CompileLdcR8(e, expectType); break;
                case ILCode.DefaultValue: CompileDefaultValue(e, expectType); break;

                //Vars
                case ILCode.Ldloc: CompileLdloc(e, expectType); break;

                //Fields
                case ILCode.Stfld: CompileStfld(e, expectType); break;
                case ILCode.Stsfld: CompileStfld(e, expectType); break;
                case ILCode.Ldfld: CompileLdfld(e, expectType); break;
                case ILCode.Ldsfld: CompileLdfld(e, expectType); break;

                //Calls
                case ILCode.Call: CompileCall(e, expectType); break;
                case ILCode.Callvirt: CompileCall(e, expectType); break;
                case ILCode.Ret: CompileRet(e, expectType); break;

                default: unknownNode = true; break;
            }

            if (unknownNode)
                Messages.Message(MessageCode.UnknownNode, e.ToString());
        }

        private void CompileBlock(ILBlock block)
        {
            foreach (ILNode node in block.Body)
                CompileNode(node, ExpectType.None);
        }
    }
}
