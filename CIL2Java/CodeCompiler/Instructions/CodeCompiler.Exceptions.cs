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

        private void CompileRethrow(ILExpression e, ExpectType expect)
        {
            if (exceptionVar.Count == 0)
            {
                Messages.Message(MessageCode.NoExceptionForRethrow);
                codeGenerator.Add(Java.OpCodes.aconst_null, null, e);
            }
            else
                codeGenerator.AddLoad(JavaPrimitiveType.Ref, exceptionVar.Peek());

            codeGenerator.Add(Java.OpCodes.athrow, null, e);
        }
    }
}
