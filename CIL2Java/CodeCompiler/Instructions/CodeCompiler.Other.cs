using CIL2Java.Java;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLoopOrSwitchBreak(ILExpression e, ExpectType expect)
        {
            codeGenerator.Add(Java.OpCodes._goto, loopOrSwitchExitLabel.Peek(), e);
        }

        private void CompileBr(ILExpression e, ExpectType expect)
        {
            codeGenerator.Add(Java.OpCodes._goto, ((ILLabel)e.Operand).Name , e);
        }

        private void CompileBreak(ILExpression e, ExpectType expect)
        {
            if (Program.CompileBreak)
                codeGenerator.Add(Java.OpCodes.breakpoint, null, e);
        }

        private void CompileNop(ILExpression e, ExpectType expect)
        {
        }

        private void CompileCkfinite(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            if (operand.PrimitiveType == PrimitiveType.Double)
                codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.CkfiniteDoubleRef, e);
            else if (operand.PrimitiveType == PrimitiveType.Single)
                codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.CkfiniteFloatRef, e);
            else throw new Exception(); //In valid CIL code this never will happed
        }

        private void CompileLocalloc(ILExpression e, ExpectType expect)
        {
            Messages.Message(MessageCode.UnsafeInstruction, e.Code.ToString());

            CompileExpression(e.Arguments[0], ExpectType.Primitive);
            codeGenerator.AddNewArray(JavaArrayType.Byte, e);
        }
    }
}
