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
    }
}
