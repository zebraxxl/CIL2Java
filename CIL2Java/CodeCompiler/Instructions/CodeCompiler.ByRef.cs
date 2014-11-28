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
        private void CompileLdloca(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            string localByRefName = byRefController.GetLocalByRefTypeName(operandType);
            Java.Constants.Class localByRefNameClass =
                new Java.Constants.Class(namesController.TypeNameToJava(localByRefName));
            Java.Constants.MethodRef localByRefInitMethodRef =
                byRefController.GetLocalByRefCtorMethodRef(operandType);
            Java.Constants.MethodRef getValueMethodRef =
                byRefController.GetByRefGetValueMethodRef(JavaHelpers.InterTypeToJavaPrimitive(operandType));

            int localRefTempVar = GetNextFreeVar(JavaPrimitiveType.Ref);

            codeGenerator
                .Add(OpCodes._new, localByRefNameClass, e)
                .Add(OpCodes.dup, null, e)
                .AddLocalVarInstruction(LocalVarInstruction.Load, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e)
                .Add(OpCodes.invokespecial, localByRefInitMethodRef, e)
                .Add(OpCodes.dup, null, e)
                .AddLocalVarInstruction(LocalVarInstruction.Store, JavaPrimitiveType.Ref, localRefTempVar, e);

            RegisterLocalByRef(() =>
            {
                codeGenerator
                    .AddLocalVarInstruction(LocalVarInstruction.Load, JavaPrimitiveType.Ref, localRefTempVar, e)
                    .Add(OpCodes.invokevirtual, getValueMethodRef, e);

                if (!operandType.IsPrimitive)
                    codeGenerator.Add(OpCodes.checkcast,
                        new Java.Constants.Class(namesController.TypeNameToJava(operandType.Fullname)), e);

                codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Store, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);

                FreeVar(localRefTempVar, JavaPrimitiveType.Ref);
            });

            //TODO: TranslateType if neeeded
        }

        private void CompileLdflda(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            string byRefTypeName = byRefController.GetFieldByRefTypeName(operand.FieldType);

            Java.Constants.Class constByRefType = new Java.Constants.Class(namesController.TypeNameToJava(byRefTypeName));
            Java.Constants.Class constFieldDeclClass =
                new Java.Constants.Class(namesController.TypeNameToJava(operand.DeclaringType.Fullname));
            Java.Constants.String constFieldName = new Java.Constants.String(
                namesController.FieldNameToJava(operand.Name));
            MethodRef constFieldByRefCtorRef = byRefController.GetFieldByRefCtorMethodRef(operand.FieldType);

            codeGenerator.Add(OpCodes._new, constByRefType, e);
            codeGenerator.Add(OpCodes.dup, null, e);

            if (e.Code == ILCode.Ldflda)
                CompileExpression(e.Arguments[0], ExpectType.Reference);
            else
                codeGenerator.Add(OpCodes.aconst_null, null, e);

            codeGenerator.Add(OpCodes.ldc, constFieldDeclClass, e);
            codeGenerator.Add(OpCodes.ldc, constFieldName, e);
            codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangClass.getDeclaredField, e);
            codeGenerator.Add(OpCodes.invokespecial, constFieldByRefCtorRef);
        }

        private void CompileLdelema(ILExpression e, ExpectType expectType)
        {
            TypeReference typeRef = e.Operand as TypeReference;
            InterType operand = resolver.Resolve(typeRef, thisMethod.FullGenericArguments);
            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand);

            string arrayByRefName = byRefController.GetArrayByRefTypeName(operand);
            Java.Constants.Class arrayByRefNameClass =
                new Java.Constants.Class(namesController.TypeNameToJava(arrayByRefName));
            Java.Constants.MethodRef arrayByRefInitMethodRef =
                byRefController.GetArrayByRefCtorMethodRef(operand);

            codeGenerator
                .Add(OpCodes._new, arrayByRefNameClass, e)
                .Add(OpCodes.dup, null, e);

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index

            codeGenerator.Add(OpCodes.invokespecial, arrayByRefInitMethodRef, e);
        }

        private void CompileStind(ILExpression e, ExpectType expectType)
        {
            JavaPrimitiveType type = JavaPrimitiveType.Ref;

            if (e.Operand != null)
            {
                InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
                type = JavaHelpers.InterTypeToJavaPrimitive(operand);
            }

            CompileExpression(e.Arguments[0], ExpectType.ByRef);
            CompileExpression(e.Arguments[1], GetExpectType(type));

            Java.Constants.MethodRef setMethodRef = byRefController.GetByRefSetValueMethodRef(type);

            codeGenerator.Add(OpCodes.invokevirtual, setMethodRef, e);
        }
    }
}
