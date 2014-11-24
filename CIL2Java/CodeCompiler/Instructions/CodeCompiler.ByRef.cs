using CIL2Java.Java;
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
