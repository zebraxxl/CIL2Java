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
        private void CompileFieldLoadThreadLocal(InterField operand, object tag)
        {
            InterType fldType = operand.FieldType;

            codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangThreadLocal.GetMethodRef, tag);

            if ((fldType.IsPrimitive) || (fldType.IsValueType) || (fldType.IsEnum))
                CompileUnbox_Any(
                    new ILExpression(ILCode.Unbox_Any, fldType,
                        new ILExpression(ILCode.Nop, null)),
                    GetExpectType(fldType));
            else
                codeGenerator.Add(OpCodes.checkcast, new Java.Constants.Class(namesController.TypeNameToJava(
                    fldType)), tag);
        }

        private void CompileFieldLoad(InterField operand, object tag, bool getFromThreadLocal = true)
        {
            string fldDesc = namesController.GetFieldDescriptor(operand.FieldType);
            if ((operand.IsStatic) && (operand.IsThreadLocal))
                fldDesc = "L" + namesController.TypeNameToJava(ClassNames.JavaLangThreadLocal.ClassName) + ";";

            if (((operand.IsPrivate) && (operand.DeclaringType != thisMethod.DeclaringType)) ||
                ((operand.IsProtected) && (operand.DeclaringType != thisMethod.DeclaringType) &&
                (!thisMethod.DeclaringType.IsSuper(operand.DeclaringType))))
            {
                string accessMethodName = operand.DeclaringType.AddFieldAccessor(new FieldAccessor(FieldAccessorType.Getter, operand));

                MethodRef accessMethod = new MethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    accessMethodName,
                    "(" + (operand.IsStatic ? "" : namesController.GetFieldDescriptor(operand.DeclaringType)) + ")"
                        + fldDesc);
                codeGenerator.Add(Java.OpCodes.invokestatic, accessMethod);
            }
            else
            {
                codeGenerator.AddInstruction(new JavaInstruction(
                    operand.IsStatic ? Java.OpCodes.getstatic : Java.OpCodes.getfield,
                    new Java.Constants.FieldRef(
                        namesController.TypeNameToJava(operand.DeclaringType),
                        namesController.FieldNameToJava(operand.Name),
                        fldDesc),
                    tag));
            }

            if ((operand.IsStatic) && (operand.IsThreadLocal) && (getFromThreadLocal))
                CompileFieldLoadThreadLocal(operand, tag);
        }

        private void CompileFieldStore(InterField operand, object tag)
        {
            if ((operand.IsStatic) && (operand.IsThreadLocal))
            {
                CompileFieldLoad(operand, tag, false);
                codeGenerator.Add(OpCodes.swap, null, tag);
                codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangThreadLocal.SetMethodRef, tag);
                return;
            }

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
            bool needDup = ((e.ExpectedType != null) && (expectType != ExpectType.None));

            bool boxed = operand.IsStatic && operand.IsThreadLocal;

            int argIndex = 0;
            if (e.Code == ILCode.Stfld)
                CompileExpression(e.Arguments[argIndex++], ExpectType.Reference);

            CompileExpression(e.Arguments[argIndex++], boxed ? ExpectType.Boxed : GetExpectType(operand));

            if (needDup)
            {
                JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(operand.FieldType);
                if (e.Code == ILCode.Stfld)
                {
                    if (jp.IsDoubleSlot())
                        codeGenerator.Add(Java.OpCodes.dup2_x1, null, e);
                    else
                        codeGenerator.Add(Java.OpCodes.dup_x1, null, e);
                }
                else
                {
                    if (jp.IsDoubleSlot())
                        codeGenerator.Add(Java.OpCodes.dup2, null, e);
                    else
                        codeGenerator.Add(Java.OpCodes.dup, null, e);
                }
            }

            CompileFieldStore(operand, e);
        }

        private void CompileLdfld(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            if (e.Code == ILCode.Ldfld)
                CompileExpression(e.Arguments[0], ExpectType.Reference);

            CompileFieldLoad(operand, e);

            if (operand.FieldType.IsValueType)
            {
                MethodRef getCopyRef = new MethodRef(namesController.TypeNameToJava(operand.FieldType),
                    ClassNames.ValueTypeGetCopy, "()" + namesController.GetFieldDescriptor(operand.FieldType));
                codeGenerator.Add(Java.OpCodes.invokevirtual, getCopyRef, e);
            }

            TranslateType(operand.FieldType, expectType, e);
        }
    }
}
