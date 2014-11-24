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

        private void CompileDefaultValue(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            codeGenerator.AddDefaultValue(JavaHelpers.InterTypeToJavaPrimitive(operand), e);
            TranslateType(operand, expect, e);
        }
    }
}
