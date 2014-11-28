using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

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

        private void CompileNewmultiarray(ILExpression e, ExpectType expect)
        {
            InterMethod ctor = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);
            InterType arrType = ctor.DeclaringType;

            for (int i = 0; i < arrType.ArrayRank; i++)
                CompileExpression(e.Arguments[i], ExpectType.Primitive);

            //TODO: lower and apper bounds

            codeGenerator.AddMultianewarray(new Java.Constants.Class(namesController.GetFieldDescriptor(arrType)),
                (byte)arrType.ArrayRank);
        }

        private void CompileArrayCall(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //first index

            for (int i = 0; i < operand.DeclaringType.ArrayRank - 1; i++)
            {
                codeGenerator.Add(Java.OpCodes.aaload, null, e);
                CompileExpression(e.Arguments[i + 2], ExpectType.Primitive);
            }

            if (operand.Name == "Set")
                CompileArraySet(e, expect);
        }

        private void CompileArraySet(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments.Last(), GetExpectType(operand.DeclaringType.ElementType));

            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand.DeclaringType);
            codeGenerator.AddArrayStore(arrType, e);
        }
    }
}
