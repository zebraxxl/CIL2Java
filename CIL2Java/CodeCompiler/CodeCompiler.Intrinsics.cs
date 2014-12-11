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
        private void CompileIntrinsicCreatePointerToArray(ILExpression e)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);
            InterType refType = operand.GenericArguments[0].Type;

            string arrayByRefName = byRefController.GetArrayByRefTypeName(refType);
            Java.Constants.Class arrayByRefNameClass =
                new Java.Constants.Class(namesController.TypeNameToJava(arrayByRefName));
            Java.Constants.MethodRef arrayByRefInitMethodRef =
                byRefController.GetArrayByRefCtorMethodRef(refType);

            codeGenerator
                .Add(OpCodes._new, arrayByRefNameClass, e)
                .Add(OpCodes.dup, null, e);

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index

            codeGenerator.Add(OpCodes.invokespecial, arrayByRefInitMethodRef, e);
        }

        private void CompileIntrinsicGetBoxedDataFromPointer(ILExpression e)
        {
            CompileExpression(e.Arguments[0], ExpectType.Any);

            string labelsSufix = rnd.Next().ToString();
            string exitLabel = "exit" + labelsSufix;
            int i = 0;

            foreach (JavaPrimitiveType jp in byRefController.GetByRefTypes())
            {
                if (jp != JavaPrimitiveType.Ref)
                {
                    continue;
                    //TODO: Box in CompileIntrinsicGetBoxedDataFromPointer
                }

                string nextLabel = "next" + (i++).ToString() + labelsSufix;

                MethodRef getValueRef = byRefController.GetByRefGetValueMethodRef(jp);

                codeGenerator
                    .Add(OpCodes.dup, null, e)
                    .Add(OpCodes.instanceof, new Java.Constants.Class(getValueRef.Class), e)
                    .Add(OpCodes.ifeq, nextLabel, e)
                    .Add(OpCodes.checkcast, new Java.Constants.Class(getValueRef.Class), e)
                    .Add(OpCodes.invokevirtual, getValueRef, e);


                codeGenerator
                    .Add(OpCodes._goto, exitLabel, e)
                    .Label(nextLabel);
            }

            codeGenerator.Label(exitLabel);
        }

        private void CompileIntrinsicGetClass(ILExpression e)
        {
            e = e.Arguments[0].Arguments[0];
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            codeGenerator.Add(OpCodes.ldc, new Java.Constants.Class(namesController.TypeNameToJava(
                operand.Fullname)), e);
        }
    }
}
