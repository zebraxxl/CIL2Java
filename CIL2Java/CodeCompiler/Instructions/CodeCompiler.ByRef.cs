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

            if (operandType.IsValueType)
            {
                codeGenerator.AddLoad(JavaPrimitiveType.Ref, varIndex);
                return;
            }

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
                        new Java.Constants.Class(namesController.TypeNameToJava(operandType)), e);

                codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Store, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);

                FreeVar(localRefTempVar, JavaPrimitiveType.Ref);
            });

            //TODO: TranslateType if neeeded
        }

        private void CompileLdflda(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.FieldType.IsValueType)
            {
                if (e.Code == ILCode.Ldflda)
                    CompileExpression(e.Arguments[0], ExpectType.Reference);

                CompileFieldLoad(operand, e);

                return;
            }

            string byRefTypeName = byRefController.GetFieldByRefTypeName(operand.FieldType);

            Java.Constants.Class constByRefType = new Java.Constants.Class(namesController.TypeNameToJava(byRefTypeName));
            Java.Constants.Class constFieldDeclClass =
                new Java.Constants.Class(namesController.TypeNameToJava(operand.DeclaringType));
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
            codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangClass.getDeclaredFieldRef, e);
            codeGenerator.Add(OpCodes.invokespecial, constFieldByRefCtorRef);
        }

        private void CompileLdelema(ILExpression e, ExpectType expectType)
        {
            TypeReference typeRef = e.Operand as TypeReference;
            InterType operand = resolver.Resolve(typeRef, thisMethod.FullGenericArguments);
            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand);

            if (operand.IsValueType)
            {
                CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
                CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index

                codeGenerator.Add(OpCodes.aaload, null, e);
                return;
            }

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

        private void CompileLdind(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Arguments[0].InferredType, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.ByRef);

            MethodRef getMethodRef = byRefController.GetByRefGetValueMethodRef(JavaHelpers.InterTypeToJavaPrimitive(
                operand.ElementType));
            InterType loadType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            Java.Constants.Class loadedTypeRef = new Java.Constants.Class(namesController.TypeNameToJava(loadType));

            codeGenerator.Add(OpCodes.invokevirtual, getMethodRef, e);

            if (!operand.ElementType.IsPrimitive)
                codeGenerator.Add(OpCodes.checkcast, loadedTypeRef, e);
        }

        private void CompileStind(ILExpression e, ExpectType expectType)
        {
            JavaPrimitiveType type = JavaPrimitiveType.Ref;

            if (e.Operand != null)
            {
                InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

                if ((operand.IsPrimitive) && ((operand.PrimitiveType == PrimitiveType.Byte) ||
                    (operand.PrimitiveType == PrimitiveType.SByte)))
                {
                    operand = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments).ElementType;
                }

                type = JavaHelpers.InterTypeToJavaPrimitive(operand);
            }

            bool needDup = ((e.ExpectedType != null) && (expectType != ExpectType.None));

            CompileExpression(e.Arguments[0], ExpectType.ByRef);
            CompileExpression(e.Arguments[1], GetExpectType(type));

            Java.Constants.MethodRef setMethodRef = byRefController.GetByRefSetValueMethodRef(type);

            if (needDup)
            {
                if (type.IsDoubleSlot())
                    codeGenerator.Add(OpCodes.dup2_x1, null, e);
                else
                    codeGenerator.Add(OpCodes.dup_x1, null, e);
            }

            codeGenerator.Add(OpCodes.invokevirtual, setMethodRef, e);
        }

        private void CompileAddressOf(ILExpression e, ExpectType expectType)
        {
            e = e.Arguments[0];

            if (e.Operand is TypeReference)
            {
                //ValueType
                CompileExpression(e, expectType);
                return;
            }
            else if (!(e.Operand is MethodReference))
            {
                CompileExpression(e, ExpectType.Boxed);
                return;
            }

            InterMethod method = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);
            InterType operand = method.DeclaringType;

            if (!operand.IsArray)
            {
                //Getter
                if (method.ReturnParameter.Type.IsPrimitive)
                    CompileExpression(e, ExpectType.Boxed);
                else
                    CompileExpression(e, GetExpectType(method.ReturnParameter));
                return;
            }

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
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //first index

            for (int i = 0; i < operand.ArrayRank - 1; i++)
            {
                codeGenerator.Add(Java.OpCodes.aaload, null, e);
                CompileExpression(e.Arguments[i + 2], ExpectType.Primitive);
            }

            codeGenerator.Add(OpCodes.invokespecial, arrayByRefInitMethodRef, e);
        }
    }
}
