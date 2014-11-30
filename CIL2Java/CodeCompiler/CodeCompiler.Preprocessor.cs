using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void PreprocessorFindAndMoveSuperOrThisCalls()
        {
            if (!thisMethod.IsConstructor) return;

            ILExpression call = null;

            foreach (ILNode node in ilBody.Body)
            {
                ILExpression e = node as ILExpression;
                if (e == null) continue;
                if (e.Code != ILCode.Call) continue;
                
                InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);
                if (!operand.IsConstructor) continue;
                if (operand.DeclaringType != thisMethod.DeclaringType)
                {
                    if (operand.DeclaringType != thisMethod.DeclaringType.BaseType) continue;
                }

                call = e;
                break;
            }

            if (call != null)
            {
                ilBody.Body.Remove(call);
                firstCall = call;
            }
        }

        private void RunPreprocessor()
        {
            PreprocessorFindAndMoveSuperOrThisCalls();
        }
    }
}
