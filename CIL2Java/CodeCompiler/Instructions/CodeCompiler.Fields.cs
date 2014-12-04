﻿using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileFieldLoad(InterField operand, object tag)
        {
            if (((operand.IsPrivate) && (operand.DeclaringType != thisMethod.DeclaringType)) ||
                ((operand.IsProtected) && (operand.DeclaringType != thisMethod.DeclaringType) &&
                (!thisMethod.DeclaringType.IsSuper(operand.DeclaringType))))
            {
                string accessMethodName = operand.DeclaringType.AddFieldAccessor(new FieldAccessor(FieldAccessorType.Getter, operand));

                MethodRef accessMethod = new MethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    accessMethodName,
                    "(" + namesController.GetFieldDescriptor(operand.DeclaringType) + ")"
                        + namesController.GetFieldDescriptor(operand.FieldType));
                codeGenerator.Add(Java.OpCodes.invokestatic, accessMethod);
            }
            else
            {
                codeGenerator.AddInstruction(new JavaInstruction(
                    operand.IsStatic ? Java.OpCodes.getstatic : Java.OpCodes.getfield,
                    new Java.Constants.FieldRef(
                        namesController.TypeNameToJava(operand.DeclaringType),
                        namesController.FieldNameToJava(operand.Name),
                        namesController.GetFieldDescriptor(operand.FieldType)),
                    tag));
            }
        }

        private void CompileFieldStore(InterField operand, object tag)
        {
            if (((operand.IsPrivate) && (operand.DeclaringType != thisMethod.DeclaringType)) ||
                ((operand.IsProtected) && (operand.DeclaringType != thisMethod.DeclaringType) &&
                (!thisMethod.DeclaringType.IsSuper(operand.DeclaringType))))
            {
                string accessMethodName = operand.DeclaringType.AddFieldAccessor(new FieldAccessor(FieldAccessorType.Setter, operand));

                MethodRef accessMethod = new MethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    accessMethodName,
                    "(" + namesController.GetFieldDescriptor(operand.DeclaringType)
                        + namesController.GetFieldDescriptor(operand.FieldType) + ")V");
                codeGenerator.Add(Java.OpCodes.invokestatic, accessMethod);
            }
            else
            {
                codeGenerator.AddInstruction(new JavaInstruction(
                    operand.IsStatic ? Java.OpCodes.putstatic : Java.OpCodes.putfield,
                    new Java.Constants.FieldRef(
                        namesController.TypeNameToJava(operand.DeclaringType),
                        namesController.FieldNameToJava(operand.Name),
                        namesController.GetFieldDescriptor(operand.FieldType)),
                    tag));
            }
        }

        private void CompileStfld(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            int argIndex = 0;
            if (e.Code == ILCode.Stfld)
                CompileExpression(e.Arguments[argIndex++], ExpectType.Reference);

            CompileExpression(e.Arguments[argIndex++], GetExpectType(operand));

            CompileFieldStore(operand, e);
        }

        private void CompileLdfld(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            if (e.Code == ILCode.Ldfld)
                CompileExpression(e.Arguments[0], ExpectType.Reference);

            CompileFieldLoad(operand, e);

            //TODO: dup

            TranslateType(operand.FieldType, expectType, e);
        }
    }
}
