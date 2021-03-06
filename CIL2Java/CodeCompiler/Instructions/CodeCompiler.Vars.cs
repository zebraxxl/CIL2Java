﻿using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLdloc(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            //TODO: GetExpectType(InterParameter);
            codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Load, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);

            if ((operandType.IsValueType) && (expectType != ExpectType.ByRef))
            {
                MethodRef getCopyRef = new MethodRef(namesController.TypeNameToJava(operandType),
                    ClassNames.ValueTypeGetCopy, "()" + namesController.GetFieldDescriptor(operandType));
                codeGenerator.Add(Java.OpCodes.invokevirtual, getCopyRef, e);
            }

            TranslateType(operandType, expectType, e);
        }

        private void CompileStloc(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            if ((operandType.IsValueType) && (e.Arguments[0].Code == ILCode.DefaultValue))
            {
                // In il this looks like `initobj(ldloca(var))`
                // But ILSpy optimizing it to `stloc(var, defaultvalue())`

                MethodRef zeroFillRef = new MethodRef(namesController.TypeNameToJava(operandType),
                    ClassNames.ValueTypeZeroFill, "()V");

                codeGenerator
                    .AddLoad(JavaPrimitiveType.Ref, varIndex)
                    .Add(Java.OpCodes.invokevirtual, zeroFillRef);
            }
            else
            {
                //TODO: GetExpectType(InterParameter);
                CompileNode(e.Arguments[0], GetExpectType(operandType));

                if ((expectType != ExpectType.None) && (e.ExpectedType != null))
                {
                    if ((operandType.IsPrimitive) && ((operandType.PrimitiveType == PrimitiveType.UInt64) ||
                        (operandType.PrimitiveType == PrimitiveType.Int64) || (operandType.PrimitiveType == PrimitiveType.Double)))
                        codeGenerator.Add(Java.OpCodes.dup2);
                    else
                        codeGenerator.Add(Java.OpCodes.dup);
                }

                codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Store, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);
            }
        }
    }
}
