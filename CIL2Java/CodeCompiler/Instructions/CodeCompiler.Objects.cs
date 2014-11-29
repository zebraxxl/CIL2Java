using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileNewobj(ILExpression e, ExpectType expect)
        {
            InterMethod ctor = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            if (ctor.DeclaringType.IsArray)
                CompileNewmultiarray(e, expect);
            else
            {
                Java.Constants.Class declTypeClassRef = new Java.Constants.Class(
                    namesController.TypeNameToJava(ctor.DeclaringType.Fullname));

                codeGenerator
                    .Add(Java.OpCodes._new, declTypeClassRef, e)
                    .Add(Java.OpCodes.dup, null, e);

                CompileCall(e, expect);
            }
        }

        private void CompileStobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.IsPrimitive)
            {
                // From ECMA-335, III.4.29
                // The stobj instruction copies the value src to the address dest. If typeTok is not
                // a generic parameter and either a reference type or a built-in value class, then 
                // the stind instruction provides a shorthand for the stobj instruction.
                CompileStind(e, expect);
            }
            else
            {
                //TODO: CompileStobj
            }
        }
    }
}
