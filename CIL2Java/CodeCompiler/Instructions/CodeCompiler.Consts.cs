using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLdstr(ILExpression e, ExpectType expect)
        {
            string operand = (string)e.Operand;

            codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.ldc, new Java.Constants.String(operand), e));

            TranslateType(resolver.Resolve(e.ExpectedType, thisMethod.FullGenericArguments), expect, e);
        }

        private void CompileLdcR4(ILExpression e, ExpectType expect)
        {
            float operand = (float)e.Operand;

            if (operand == 0.0f)
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.fconst_0, null, e));
            else if (operand == 1.0f)
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.fconst_1, null, e));
            else if (operand == 2.0f)
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.fconst_2, null, e));
            else
            {
                //TODO: From Java Virtual Machine Specification:
                //The ldc instruction can only be used to push a value of type float taken from the float value set (§2.3.2)
                //because a constant of type float in the constant pool (§4.4.4) must be taken from the float value set.
                //What this means, and check this (may be NaN and Inf?)

                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.ldc, new Java.Constants.Float(operand), e));
            }

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Single], expect, e);
        }

        private void CompileLdcR8(ILExpression e, ExpectType expect)
        {
            double operand = (double)e.Operand;

            if (operand == 0.0)
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.dconst_0, null, e));
            else if (operand == 1.0)
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.dconst_1, null, e));
            else
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.ldc2_w, new Java.Constants.Double(operand), e));

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Single], expect, e);
        }

        private void CompileLdcI4(ILExpression e, ExpectType expect)
        {
            int operand = (int)e.Operand;

            switch (operand)
            {
                case -1: codeGenerator.Add(Java.OpCodes.iconst_m1, null, e); break;
                case 0: codeGenerator.Add(Java.OpCodes.iconst_0, null, e); break;
                case 1: codeGenerator.Add(Java.OpCodes.iconst_1, null, e); break;
                case 2: codeGenerator.Add(Java.OpCodes.iconst_2, null, e); break;
                case 3: codeGenerator.Add(Java.OpCodes.iconst_3, null, e); break;
                case 4: codeGenerator.Add(Java.OpCodes.iconst_4, null, e); break;
                case 5: codeGenerator.Add(Java.OpCodes.iconst_5, null, e); break;

                default:
                    if ((operand >= sbyte.MinValue) && (operand <= sbyte.MaxValue))
                        codeGenerator.Add(Java.OpCodes.bipush, (sbyte)operand, e);
                    else if ((operand >= short.MinValue) && (operand <= short.MaxValue))
                        codeGenerator.Add(Java.OpCodes.sipush, (short)operand);
                    else
                        codeGenerator.Add(Java.OpCodes.ldc, new Java.Constants.Integer(operand), e);
                    break;
            }

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Int32], expect, e);
        }

        private void CompileLdcI8(ILExpression e, ExpectType expect)
        {
            long operand = (long)e.Operand;

            codeGenerator.AddLongConst(operand, e);

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Int32], expect, e);
        }

        private void CompileLdnull(ILExpression e, ExpectType expect)
        {
            codeGenerator.Add(Java.OpCodes.aconst_null, null, e);
        }

        private void CompileDefaultValue(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.IsValueType)
            {
                Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(operand));
                MethodRef operandCtorRef = new MethodRef(operandRef.Value, ClassNames.JavaConstructorMethodName, "()V");

                codeGenerator
                    .Add(Java.OpCodes._new, operandRef, e)
                    .Add(Java.OpCodes.dup, null, e)
                    .Add(Java.OpCodes.invokespecial, operandCtorRef, e);
            }
            else
                codeGenerator.AddDefaultValue(JavaHelpers.InterTypeToJavaPrimitive(operand), e);
            TranslateType(operand, expect, e);
        }

        private void CompileLdcDecimal(ILExpression e, ExpectType expect)
        {
            decimal operand = (decimal)e.Operand;
            int[] bits = decimal.GetBits(operand);

            codeGenerator
                .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.SystemDecimal.ClassNames)), e)
                .Add(OpCodes.dup, null, e)

                .Add(OpCodes.iconst_4, null, e)
                .AddNewArray(JavaArrayType.Int, e)

                .Add(OpCodes.dup, null, e)
                .Add(OpCodes.iconst_0, null, e)
                .AddIntConst(bits[0], e)
                .Add(OpCodes.iastore, null, e)

                .Add(OpCodes.dup, null, e)
                .Add(OpCodes.iconst_1, null, e)
                .AddIntConst(bits[1], e)
                .Add(OpCodes.iastore, null, e)

                .Add(OpCodes.dup, null, e)
                .Add(OpCodes.iconst_2, null, e)
                .AddIntConst(bits[2], e)
                .Add(OpCodes.iastore, null, e)

                .Add(OpCodes.dup, null, e)
                .Add(OpCodes.iconst_3, null, e)
                .AddIntConst(bits[3], e)
                .Add(OpCodes.iastore, null, e)

                .Add(OpCodes.invokespecial, ClassNames.SystemDecimal.FromBitsCtorRef, e);
        }
    }
}
