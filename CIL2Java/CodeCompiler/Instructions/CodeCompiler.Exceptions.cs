using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileThrow(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Reference);

            codeGenerator.Add(Java.OpCodes.athrow, null, e);
        }
    }
}
