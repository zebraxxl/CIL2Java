using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
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
            //TODO: e.Arguments may not be bool
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

            codeGenerator
                .Add(Java.OpCodes.ifeq, zeroLabel, e)
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

        private void CompileFlowC(ILExpression e, Java.OpCodes IntCmp, Java.OpCodes RefCmp, Java.OpCodes OtherCmp)
        {
            CompileExpression(e.Arguments[0], ExpectType.Any);
            CompileExpression(e.Arguments[1], ExpectType.Any);

            JavaPrimitiveType jpt = JavaHelpers.InterTypeToJavaPrimitive(
                resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments));

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
            //TODO: unsigned numbers
            CompileFlowC(e, Java.OpCodes.if_icmple, Java.OpCodes.if_acmpeq, Java.OpCodes.ifle);
        }
    }
}
