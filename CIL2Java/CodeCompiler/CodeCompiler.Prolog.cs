using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        ILExpression firstCall = null;

        private byte[] GenerateMethodProlog()
        {
            codeGenerator = new JavaBytecodeWriter();

            if (thisMethod.IsConstructor)
            {
                if (firstCall != null)
                    CompileExpression(firstCall, ExpectType.Any);
                else
                {
                    string typeName = namesController.TypeNameToJava(thisMethod.DeclaringType.BaseType.Fullname);
                    if ((thisMethod.DeclaringType.IsValueType) && (thisMethod.Parameters.Count > 0))
                    {
                        //call to this() to initialize all fields
                        typeName = namesController.TypeNameToJava(thisMethod.DeclaringType.Fullname);
                    }

                    MethodRef superCall = new MethodRef(typeName, ClassNames.JavaConstructorMethodName, "()V");
                    codeGenerator
                        .Add(OpCodes.aload_0)
                        .Add(OpCodes.invokespecial, superCall);
                }
            }

            foreach (ValueTypeVar v in valueTypesVars)
            {
                Java.Constants.Class typeRef = new Java.Constants.Class(namesController.TypeNameToJava(v.varType.Fullname));
                Java.Constants.MethodRef ctorRef = new Java.Constants.MethodRef(typeRef.Value,
                    ClassNames.JavaConstructorMethodName, "()V");

                codeGenerator
                    .Add(Java.OpCodes._new, typeRef)
                    .Add(Java.OpCodes.dup)
                    .Add(Java.OpCodes.invokespecial, ctorRef)
                    .AddStore(JavaPrimitiveType.Ref, v.varIndex);
            }

            return codeGenerator.End(constsPool).CodeBytes;
        }
    }
}
