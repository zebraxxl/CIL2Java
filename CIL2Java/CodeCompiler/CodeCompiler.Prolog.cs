using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private byte[] GenerateMethodProlog()
        {
            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();

            foreach (ValueTypeVar v in valueTypesVars)
            {
                Java.Constants.Class typeRef = new Java.Constants.Class(namesController.TypeNameToJava(v.varType.Fullname));
                Java.Constants.MethodRef ctorRef = new Java.Constants.MethodRef(typeRef.Value,
                    ClassNames.JavaConstructorMethodName, "()V");

                codeWriter
                    .Add(Java.OpCodes._new, typeRef)
                    .Add(Java.OpCodes.dup)
                    .Add(Java.OpCodes.invokespecial, ctorRef)
                    .AddStore(JavaPrimitiveType.Ref, v.varIndex);
            }

            return codeWriter.End(constsPool).CodeBytes;
        }
    }
}
