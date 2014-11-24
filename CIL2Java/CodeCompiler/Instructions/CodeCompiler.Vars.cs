using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLdloc(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            //TODO: GetExpectType(InterParameter);
            codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Load, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);

            TranslateType(operandType, expectType, e);
        }

        private void CompileStloc(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            //TODO: GetExpectType(InterParameter);
            CompileNode(e.Arguments[0], GetExpectType(operandType));

            codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Store, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);
        }
    }
}
