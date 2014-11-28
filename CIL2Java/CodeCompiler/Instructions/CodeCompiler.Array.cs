using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileNewarr(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            JavaArrayType arrayType = JavaHelpers.JavaPrimitiveToArrayType(JavaHelpers.InterTypeToJavaPrimitive(operand));

            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            if (arrayType == JavaArrayType.Ref)
            {
                codeGenerator.Add(Java.OpCodes.anewarray,
                    new Java.Constants.Class(namesController.TypeNameToJava(operand.Fullname)), e);
            }
            else
                codeGenerator.AddNewArray(arrayType, e);
        }

        private void CompileStelem(ILExpression e, ExpectType expect)
        {
            TypeReference typeRef = e.Operand as TypeReference ?? e.InferredType;
            InterType operand = resolver.Resolve(typeRef, thisMethod.FullGenericArguments);
            JavaArrayType arrType = JavaHelpers.JavaPrimitiveToArrayType(JavaHelpers.InterTypeToJavaPrimitive(operand));

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index
            CompileExpression(e.Arguments[2], GetExpectType(operand));  //value

            codeGenerator.AddArrayStore(arrType, e);
        }

        private void CompileLdelem(ILExpression e, ExpectType expect)
        {
            TypeReference typeRef = e.Operand as TypeReference ?? e.InferredType;
            InterType operand = resolver.Resolve(typeRef, thisMethod.FullGenericArguments);
            JavaArrayType arrType = JavaHelpers.JavaPrimitiveToArrayType(JavaHelpers.InterTypeToJavaPrimitive(operand));

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index

            codeGenerator.AddArrayLoad(arrType, e);

            TranslateType(operand, expect, e);
        }
    }
}
