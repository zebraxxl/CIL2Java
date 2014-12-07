using CIL2Java.Java;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileMkrefany(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            codeGenerator
                .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.SystemTypedReference.ClassName)), e)
                .Add(OpCodes.dup, null, e);

            CompileExpression(e.Arguments[0], ExpectType.ByRef);

            codeGenerator
                .Add(OpCodes.ldc, new Java.Constants.Class(namesController.TypeNameToJava(operand)), e)
                .Add(OpCodes.invokespecial, ClassNames.SystemTypedReference.CtorMethodRef, e);
        }

        private void CompileRefanytype(ILExpression e, ExpectType expect)
        {
            codeGenerator
                .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.SystemRuntimeTypeHandle.ClassName)), e)
                .Add(OpCodes.dup, null, e);

            CompileExpression(e.Arguments[0], ExpectType.Reference);

            codeGenerator
                .Add(OpCodes.getfield, ClassNames.SystemTypedReference.ClassFieldRef, e)
                .Add(OpCodes.invokespecial, ClassNames.SystemRuntimeTypeHandle.CtorMethodRef, e);
        }

        private void CompileRefanyval(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            string byRefTypeName = byRefController.GetByRefGetValueMethodRef(JavaHelpers.InterTypeToJavaPrimitive(operand)).Class;

            CompileExpression(e.Arguments[0], ExpectType.Reference);
            codeGenerator
                .Add(OpCodes.getfield, ClassNames.SystemTypedReference.PointerFieldRef, e)
                .Add(OpCodes.checkcast, new Java.Constants.Class(byRefTypeName), e);
        }
    }
}
