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

        private void CompileLdcR8(ILExpression e, ExpectType expect)
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

        private void CompileDefaultValue(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            codeGenerator.AddDefaultValue(JavaHelpers.InterTypeToJavaPrimitive(operand), e);
            TranslateType(operand, expect, e);
        }
    }
}
