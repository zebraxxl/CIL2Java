using CIL2Java.Java;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private Dictionary<ILCode, ILCode> invertLogic = new Dictionary<ILCode, ILCode>()
        {
            {ILCode.__Brfalse, ILCode.Brtrue},
            {ILCode.Brtrue, ILCode.__Brfalse},
            {ILCode.__Beq, ILCode.__Bne_Un},
            {ILCode.__Bge, ILCode.__Blt},
            {ILCode.__Bgt, ILCode.__Ble},
            {ILCode.__Ble, ILCode.__Bgt},
            {ILCode.__Blt, ILCode.__Bge},
            {ILCode.__Bne_Un, ILCode.__Beq},
            {ILCode.__Bge_Un, ILCode.__Blt_Un},
            {ILCode.__Bgt_Un, ILCode.__Ble_Un},
            {ILCode.__Ble_Un, ILCode.__Bgt_Un},
            {ILCode.__Blt_Un, ILCode.__Bge_Un},
            {ILCode.Ceq, ILCode.Cne},
            {ILCode.Cgt, ILCode.Cle},
            {ILCode.Cgt_Un, ILCode.Cle_Un},
            {ILCode.Clt, ILCode.Cge},
            {ILCode.Clt_Un, ILCode.Cge_Un},
            {ILCode.Cne, ILCode.Ceq},
            {ILCode.Cge, ILCode.Clt},
            {ILCode.Cge_Un, ILCode.Clt_Un},
            {ILCode.Cle, ILCode.Cgt_Un},
            {ILCode.Cle_Un, ILCode.Cgt_Un}
        };

        private Dictionary<ILCode, ILCode> BoolToBranch = new Dictionary<ILCode, ILCode>()
        {
            {ILCode.Ceq, ILCode.__Beq},
            {ILCode.Cgt, ILCode.__Bgt},
            {ILCode.Cgt_Un, ILCode.__Bgt_Un},
            {ILCode.Clt, ILCode.__Blt},
            {ILCode.Clt_Un, ILCode.__Blt_Un},
            {ILCode.Cne, ILCode.__Bne_Un},
            {ILCode.Cge, ILCode.__Bge},
            {ILCode.Cge_Un, ILCode.__Bge_Un},
            {ILCode.Cle, ILCode.__Ble},
            {ILCode.Cle_Un, ILCode.__Ble_Un}
        };

        private void CompileCondition(ILExpression e, string onTrueLabel)
        {
            while ((e.Code == ILCode.LogicNot) && (e.Arguments[0].Code == ILCode.LogicNot))
                e = e.Arguments[0].Arguments[0];    //Remove duplicate not

            if (e.Code == ILCode.LogicNot)
            {
                //Invert codtion
                // !(a && b) = (!a) || (!b)
                // !(a || b) = (!a) && (!b)
                if (e.Arguments[0].Code == ILCode.LogicAnd)
                    e = new ILExpression(ILCode.LogicOr, null,
                            new ILExpression(ILCode.LogicNot, null, e.Arguments[0]),
                            new ILExpression(ILCode.LogicNot, null, e.Arguments[1]));
                else if (e.Arguments[0].Code == ILCode.LogicOr)
                    e = new ILExpression(ILCode.LogicAnd, null,
                            new ILExpression(ILCode.LogicNot, null, e.Arguments[0]),
                            new ILExpression(ILCode.LogicNot, null, e.Arguments[1]));
                else
                {
                    if (invertLogic.ContainsKey(e.Arguments[0].Code))
                    {
                        e = e.Arguments[0];
                        e.Code = invertLogic[e.Code];
                    }
                }
            }

            if (e.Code == ILCode.LogicAnd)
            {
                string falseLabel = "false" + rnd.Next().ToString();
                CompileCondition(new ILExpression(ILCode.LogicNot, null, e.Arguments[0]), falseLabel);
                CompileCondition(new ILExpression(ILCode.LogicNot, null, e.Arguments[1]), falseLabel);
                codeGenerator
                    .Add(Java.OpCodes._goto, onTrueLabel)
                    .Label(falseLabel);
            }
            else if (e.Code == ILCode.LogicOr)
            {
                CompileCondition(e.Arguments[0], onTrueLabel);
                CompileCondition(e.Arguments[1], onTrueLabel);
            }
            else if (BoolToBranch.ContainsKey(e.Code))
            {
                CompileExpression(
                    new ILExpression(BoolToBranch[e.Code], new ILLabel() { Name = onTrueLabel }, e.Arguments.ToArray()),
                    ExpectType.None);
            }
            else
            {
                //bool logic
                bool invert = false;
                if (e.Code == ILCode.LogicNot)
                {
                    invert = true;
                    e = e.Arguments[0];
                }

                JavaPrimitiveType gettedType = JavaHelpers.InterTypeToJavaPrimitive(resolver.Resolve(
                    e.InferredType, thisMethod.FullGenericArguments));
                CompileExpression(e, ExpectType.Any);

                OpCodes branchCode = invert ? OpCodes.ifeq : OpCodes.ifne;

                switch (gettedType)
                {
                    case JavaPrimitiveType.Double: codeGenerator.Add(Java.OpCodes.d2i, null, e); break;
                    case JavaPrimitiveType.Float: codeGenerator.Add(Java.OpCodes.f2i, null, e); break;
                    case JavaPrimitiveType.Long: codeGenerator.Add(Java.OpCodes.l2i, null, e); break;
                    case JavaPrimitiveType.Ref: branchCode = invert ? OpCodes.ifnull : OpCodes.ifnonnull; break;
                }

                codeGenerator.Add(branchCode, onTrueLabel, e);
            }
        }

        private void TranslateToBool(TypeReference inferredType, ref Java.OpCodes cmpOp, object tag)
        {
            JavaPrimitiveType gettedType = JavaHelpers.InterTypeToJavaPrimitive(resolver.Resolve(
                inferredType, thisMethod.FullGenericArguments));

            switch (gettedType)
            {
                case JavaPrimitiveType.Double: codeGenerator.Add(Java.OpCodes.d2i, null, tag); break;
                case JavaPrimitiveType.Float: codeGenerator.Add(Java.OpCodes.f2i, null, tag); break;
                case JavaPrimitiveType.Long: codeGenerator.Add(Java.OpCodes.l2i, null, tag); break;
                case JavaPrimitiveType.Ref: cmpOp = (cmpOp == Java.OpCodes.ifne ? Java.OpCodes.ifnonnull : Java.OpCodes.ifnull); break;
            }
        }

        private void CompileLogicNot(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            //  push exp
            //  ifeq zero
            //  iconst_0
            //  goto exit
            //zero:
            //  iconst_1
            //exit

            string labelSufixes = rnd.Next().ToString();
            string zeroLabel = "zero" + labelSufixes;
            string exitLabel = "exit" + labelSufixes;

            Java.OpCodes branch = Java.OpCodes.ifeq;
            TranslateToBool(e.Arguments[0].InferredType, ref branch, e);

            codeGenerator
                .Add(branch, zeroLabel, e)
                .Add(Java.OpCodes.iconst_0, null, e)
                .Add(Java.OpCodes._goto, exitLabel, e)
                .Label(zeroLabel)
                .Add(Java.OpCodes.iconst_1)
                .Label(exitLabel);
        }

        private void CompileLogicAnd(ILExpression e, ExpectType expect)
        {
            string labelsSufix = rnd.Next().ToString();

            string falseLabel = "false" + labelsSufix;
            string exitLabel = "exit" + labelsSufix;

            Java.OpCodes branch = Java.OpCodes.ifeq;

            CompileExpression(e.Arguments[0], ExpectType.Primitive);
            TranslateToBool(e.Arguments[0].InferredType, ref branch, e);

            codeGenerator.Add(branch, falseLabel, e);
            CompileExpression(e.Arguments[1], ExpectType.Primitive);
            TranslateToBool(e.Arguments[1].InferredType, ref branch, e);


            branch = Java.OpCodes.ifeq;
            codeGenerator
                .Add(branch, falseLabel, e)
                .Add(Java.OpCodes.iconst_1, null, e)
                .Add(Java.OpCodes._goto, exitLabel, e)
                .Label(falseLabel)
                .Add(Java.OpCodes.iconst_0, null, e)
                .Label(exitLabel);
        }

        private void CompileLogicOr(ILExpression e, ExpectType expect)
        {
            string labelsSufix = rnd.Next().ToString();

            string trueLabel = "true" + labelsSufix;
            string exitLabel = "exit" + labelsSufix;

            Java.OpCodes branch = Java.OpCodes.ifne;
            CompileExpression(e.Arguments[0], ExpectType.Primitive);
            TranslateToBool(e.Arguments[0].InferredType, ref branch, e);
            codeGenerator.Add(branch, trueLabel, e);

            branch = Java.OpCodes.ifne;
            CompileExpression(e.Arguments[1], ExpectType.Primitive);
            TranslateToBool(e.Arguments[1].InferredType, ref branch, e);
            
            codeGenerator
                .Add(branch, trueLabel, e)
                .Add(Java.OpCodes.iconst_0, null, e)
                .Add(Java.OpCodes._goto, exitLabel, e)
                .Label(trueLabel)
                .Add(Java.OpCodes.iconst_1, null, e)
                .Label(exitLabel);
        }

        private void CompileTernaryOp(ILExpression e, ExpectType expect)
        {
            ILCondition conditionNode = new ILCondition();
            conditionNode.Condition = e.Arguments[0];
            conditionNode.TrueBlock = new ILBlock(e.Arguments[1]);
            conditionNode.FalseBlock = new ILBlock(e.Arguments[2]);
            CompileCondition(conditionNode, expect);

            TranslateType(resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments), expect, e);
        }

        private void CompileNullCoalescing(ILExpression e, ExpectType expect)
        {
            InterType inferredType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(inferredType);

            string exitLabel = "exit" + rnd.Next().ToString();

            CompileExpression(e.Arguments[0], expect);
            codeGenerator.Add(jp.IsDoubleSlot() ? OpCodes.dup2 : OpCodes.dup, null, e);

            if (jp == JavaPrimitiveType.Ref)
                codeGenerator.Add(Java.OpCodes.ifnonnull, exitLabel, e);
            else if (jp.IsIntSlot())
                codeGenerator.Add(Java.OpCodes.ifne, exitLabel, e);
            else
            {
                if (jp == JavaPrimitiveType.Float)
                    codeGenerator.Add(OpCodes.fconst_0, null, e).Add(OpCodes.fcmpg, null, e);
                else if (jp == JavaPrimitiveType.Double)
                    codeGenerator.Add(OpCodes.dconst_0, null, e).Add(OpCodes.dcmpg, null, e);
                else if (jp == JavaPrimitiveType.Long)
                    codeGenerator.Add(OpCodes.lconst_0, null, e).Add(OpCodes.lcmp, null, e);

                codeGenerator.Add(OpCodes.ifeq, exitLabel, e);
            }

            codeGenerator.Add(jp.IsDoubleSlot() ? OpCodes.pop2 : OpCodes.pop);
            CompileExpression(e.Arguments[1], expect);
            codeGenerator.Label(exitLabel);
        }

        #region Branch logic (B* instructions)
        private void CompileFlowB(ILExpression e, OpCodes intBr, OpCodes refBr, OpCodes otherBr, bool unsigned = false)
        {
            unsigned = unsigned && Program.Unsigned;

            InterType operandTypes = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType prim = JavaHelpers.InterTypeToJavaPrimitive(operandTypes);

            Action modifOp = () => { };

            if (unsigned)
            {
                //From http://habrahabr.ru/post/225901 (author: @elw00d)
                switch (prim)
                {
                    case JavaPrimitiveType.Bool:
                    case JavaPrimitiveType.Byte:
                        modifOp = () => codeGenerator.AddIntConst(0x80, e).Add(OpCodes.ixor, null, e);
                        break;

                    case JavaPrimitiveType.Short:
                        modifOp = () => codeGenerator.AddIntConst(0x8000, e).Add(OpCodes.ixor, null, e);
                        break;

                    case JavaPrimitiveType.Int:
                        modifOp = () => codeGenerator.AddIntConst((unchecked((int)0x80000000)), e).Add(OpCodes.ixor, null, e);
                        break;

                    case JavaPrimitiveType.Long:
                        modifOp = () => codeGenerator.AddLongConst((unchecked((long)0x8000000000000000)), e).Add(OpCodes.lxor, null, e);
                        break;
                }
            }


            CompileExpression(e.Arguments[0], GetExpectType(operandTypes));
            modifOp();

            CompileExpression(e.Arguments[1], GetExpectType(operandTypes));
            modifOp();

            switch (prim)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                case JavaPrimitiveType.Short:
                    codeGenerator.Add(intBr, ((ILLabel)e.Operand).Name, e);
                    break;

                case JavaPrimitiveType.Ref:
                    codeGenerator.Add(refBr, ((ILLabel)e.Operand).Name, e);
                    break;

                default:
                    switch (prim)
                    {
                        case JavaPrimitiveType.Long: codeGenerator.Add(OpCodes.lcmp, null, e); break;
                        case JavaPrimitiveType.Float: codeGenerator.Add(OpCodes.fcmpg, null, e); break;
                        case JavaPrimitiveType.Double: codeGenerator.Add(OpCodes.dcmpg, null, e); break;
                        default: throw new Exception(); //TODO: Normal error
                    }
                    codeGenerator.Add(otherBr, ((ILLabel)e.Operand).Name, e);
                    break;
            }
        }

        private void CompileBeq(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmpeq, OpCodes.if_acmpeq, OpCodes.ifeq);
        }

        private void CompileBge(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmpge, OpCodes.if_acmpeq, OpCodes.ifge);
        }

        private void CompileBgt(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmpgt, OpCodes.if_acmpne, OpCodes.ifgt);
        }

        private void CompileBle(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmple, OpCodes.if_acmpeq, OpCodes.ifle);
        }

        private void CompileBlt(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmplt, OpCodes.if_acmpne, OpCodes.iflt);
        }

        private void CompileBneUn(ILExpression e, ExpectType expect)
        {
            //TODO: check for unordered
            CompileFlowB(e, OpCodes.if_icmpne, OpCodes.if_acmpne, OpCodes.ifne);
        }

        //TODO: Unordered checks
        private void CompileBgeUn(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmpge, OpCodes.if_acmpeq, OpCodes.ifge, true);
        }

        private void CompileBgtUn(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmpgt, OpCodes.if_acmpne, OpCodes.ifgt, true);
        }

        private void CompileBleUn(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmple, OpCodes.if_acmpeq, OpCodes.ifle, true);
        }

        private void CompileBltUn(ILExpression e, ExpectType expect)
        {
            CompileFlowB(e, OpCodes.if_icmplt, OpCodes.if_acmpne, OpCodes.iflt, true);
        }
        #endregion

        #region Compare logic (C* instructions)
        private void CompileFlowC(ILExpression e, Java.OpCodes IntCmp, Java.OpCodes RefCmp, Java.OpCodes OtherCmp, bool unsigned = false)
        {
            unsigned = unsigned && Program.Unsigned;

            JavaPrimitiveType jpt = JavaHelpers.InterTypeToJavaPrimitive(
                resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments));

            Action modifOp = () => { };

            if (unsigned)
            {
                //From http://habrahabr.ru/post/225901 (author: @elw00d)
                switch (jpt)
                {
                    case JavaPrimitiveType.Bool:
                    case JavaPrimitiveType.Byte:
                        modifOp = () => codeGenerator.AddIntConst(0x80, e).Add(OpCodes.ixor, null, e);
                        break;

                    case JavaPrimitiveType.Short:
                        modifOp = () => codeGenerator.AddIntConst(0x8000, e).Add(OpCodes.ixor, null, e);
                        break;

                    case JavaPrimitiveType.Int:
                        modifOp = () => codeGenerator.AddIntConst((unchecked((int)0x80000000)), e).Add(OpCodes.ixor, null, e);
                        break;

                    case JavaPrimitiveType.Long:
                        modifOp = () => codeGenerator.AddLongConst((unchecked((long)0x8000000000000000)), e).Add(OpCodes.lxor, null, e);
                        break;
                }
            }

            CompileExpression(e.Arguments[0], ExpectType.Any);
            modifOp();
            CompileExpression(e.Arguments[1], ExpectType.Any);
            modifOp();

            //  if OtherCmp - dcmpg or fcmpg or lcmp
            //  *Cmp true
            //  iconst_0
            //  goto end
            //:true
            //  iconst_1
            //:end

            string labelPrefix = rnd.Next().ToString();
            string trueLabel = labelPrefix + "true";
            string endLabel = labelPrefix + "end";

            switch (jpt)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Int:
                    codeGenerator.Add(IntCmp, trueLabel, e);
                    break;

                case JavaPrimitiveType.Ref: codeGenerator.Add(RefCmp, trueLabel, e); break;

                case JavaPrimitiveType.Long: codeGenerator.Add(Java.OpCodes.lcmp, null, e).Add(OtherCmp, trueLabel, e); break;
                case JavaPrimitiveType.Float: codeGenerator.Add(Java.OpCodes.fcmpg, null, e).Add(OtherCmp, trueLabel, e); break;
                case JavaPrimitiveType.Double: codeGenerator.Add(Java.OpCodes.dcmpg, null, e).Add(OtherCmp, trueLabel, e); break;
            }

            codeGenerator
                .Add(Java.OpCodes.iconst_0, null, e)
                .Add(Java.OpCodes._goto, endLabel, e)
                .Label(trueLabel)
                .Add(Java.OpCodes.iconst_1, null, e)
                .Label(endLabel);
        }

        private void CompileCeq(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmpeq, Java.OpCodes.if_acmpeq, Java.OpCodes.ifeq);
        }

        private void CompileCne(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmpne, Java.OpCodes.if_acmpne, Java.OpCodes.ifne);
        }

        private void CompileCle(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmple, Java.OpCodes.if_acmpeq, Java.OpCodes.ifle);
        }

        private void CompileClt(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmplt, Java.OpCodes.if_acmpne, Java.OpCodes.iflt);
        }

        private void CompileCge(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmpge, Java.OpCodes.if_acmpeq, Java.OpCodes.ifge);
        }

        private void CompileCgt(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmpgt, Java.OpCodes.if_acmpne, Java.OpCodes.ifgt);
        }

        private void CompileCle_Un(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmple, Java.OpCodes.if_acmpeq, Java.OpCodes.ifle, true);
        }
        #endregion

        private void CompileBrBool(ILExpression e, ExpectType expect, bool brOnTrue)
        {
            JavaPrimitiveType gettedType = JavaHelpers.InterTypeToJavaPrimitive(resolver.Resolve(
                e.InferredType, thisMethod.FullGenericArguments));

            OpCodes brInstr = brOnTrue ? OpCodes.ifne : OpCodes.ifeq;
            if (gettedType == JavaPrimitiveType.Ref)
                brInstr = brOnTrue ? OpCodes.ifnonnull : OpCodes.ifnull;

            codeGenerator.Add(brInstr, ((ILLabel)e.Operand).Name, e);
        }

        private void CompileBrtrue(ILExpression e, ExpectType expect)
        {
            CompileBrBool(e, expect, true);
        }

        private void CompileBrfalse(ILExpression e, ExpectType expect)
        {
            CompileBrBool(e, expect, false);
        }
    }
}
