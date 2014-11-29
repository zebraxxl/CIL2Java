using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLogicNot(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            //  iconst_1
            //  if_icmpne not_equal
            //  iconst_1
            //  goto end
            //not_equal:
            //  iconst_0
            //end:
            //

            string labelPrefixes = ":" + rnd.Next().ToString();

            codeGenerator
                .Add(Java.OpCodes.iconst_1, null, e)
                .Add(Java.OpCodes.if_icmpne, labelPrefixes + "not_equal", e)
                .Add(Java.OpCodes.iconst_1, null, e)
                .Add(Java.OpCodes._goto, labelPrefixes + "end", e)
                .Label(labelPrefixes + "not_equal")
                .Add(Java.OpCodes.iconst_0, null, e)
                .Label(labelPrefixes + "end");
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

        private void CompileCle(ILExpression e, ExpectType expect)
        {
            CompileFlowC(e, Java.OpCodes.if_icmple, Java.OpCodes.if_acmpeq, Java.OpCodes.ifle);
        }

        private void CompileCle_Un(ILExpression e, ExpectType expect)
        {
            //TODO: unsigned numbers
            CompileFlowC(e, Java.OpCodes.if_icmple, Java.OpCodes.if_acmpeq, Java.OpCodes.ifle);
        }
    }
}
