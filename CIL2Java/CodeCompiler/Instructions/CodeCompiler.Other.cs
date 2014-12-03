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
    }
}
