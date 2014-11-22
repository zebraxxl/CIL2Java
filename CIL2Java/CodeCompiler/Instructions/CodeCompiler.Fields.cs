using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileStfld(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            int argIndex = 0;
            if (e.Code == ILCode.Stfld)
                CompileExpression(e.Arguments[argIndex++], ExpectType.Reference);

            CompileExpression(e.Arguments[argIndex++], GetExpectType(operand));

            codeGenerator.AddInstruction(new JavaInstruction(
                e.Code == ILCode.Stsfld ? Java.OpCodes.putstatic : Java.OpCodes.putfield,
                new Java.Constants.FieldRef(
                    namesController.TypeNameToJava(operand.DeclaringType.Fullname),
                    namesController.FieldNameToJava(operand.Name),
                    namesController.GetFieldDescriptor(operand.FieldType)),
                e));
        }

        private void CompileLdfld(ILExpression e, ExpectType expectType)
        {
            InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

            if (e.Code == ILCode.Ldfld)
                CompileExpression(e.Arguments[0], ExpectType.Reference);

            codeGenerator.AddInstruction(new JavaInstruction(
                e.Code == ILCode.Ldsfld ? Java.OpCodes.getstatic : Java.OpCodes.getfield,
                new Java.Constants.FieldRef(
                    namesController.TypeNameToJava(operand.DeclaringType.Fullname),
                    namesController.FieldNameToJava(operand.Name),
                    namesController.GetFieldDescriptor(operand.FieldType)),
                e));

            TranslateType(operand.FieldType, expectType, e);
        }
    }
}
