using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        //Find this() or super() calls in ctor to move it to begin of method
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

        //Find stobj(ldloc(this), defaultValue()). It is equals to this()
        private void PreprocessorFindDefaultCtorCallInValueTypeCtor()
        {
            if ((!thisMethod.IsConstructor) || (!thisMethod.DeclaringType.IsValueType)) return;

            foreach (ILNode node in ilBody.Body)
            {
                ILExpression e = node as ILExpression;
                if (e == null) continue;

                if (e.Code != ILCode.Stobj) continue;
                if (e.Arguments[0].Code != ILCode.Ldloc) continue;
                if (((ILVariable)e.Arguments[0].Operand).Name != "this") continue;
                if (e.Arguments[1].Code != ILCode.DefaultValue) continue;

                //Founded signature. Just remove it. Prolog generator will add call to super() or this()
                ilBody.Body.Remove(e);
                break;
            }
        }

        private void RunPreprocessor()
        {
            PreprocessorFindDefaultCtorCallInValueTypeCtor();
            PreprocessorFindAndMoveSuperOrThisCalls();
        }
    }
}
