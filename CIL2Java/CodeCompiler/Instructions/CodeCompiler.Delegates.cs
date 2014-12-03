using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLdftn(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            string methodPointerClass = GenerateMethodPointerClass(operand);

            if (Program.MethodPointersType == MethodPointerImplementation.Fast)
            {
                Java.Constants.Class mpClassRef = new Java.Constants.Class(namesController.TypeNameToJava(methodPointerClass));
                MethodRef mpInitRef = new MethodRef(mpClassRef.Value, ClassNames.JavaConstructorMethodName, "()V");

                codeGenerator
                    .Add(OpCodes._new, mpClassRef, e)
                    .Add(OpCodes.dup, null, e)
                    .Add(OpCodes.invokespecial, mpInitRef, e);
            }
            else
            {
                codeGenerator
                    .Add(OpCodes.ldc, new Java.Constants.String(methodPointerClass.Replace('/', '$')))
                    .Add(OpCodes.invokestatic, ClassNames.GlobalMethodPointersAdd);
            }
        }
    }
}
