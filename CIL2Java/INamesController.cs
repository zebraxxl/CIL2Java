using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public interface INamesController
    {
        string TypeNameToJava(InterType CILName);
        string TypeNameToJava(string CILName);
        string FieldNameToJava(string CILName);
        string MethodNameToJava(string CILName);

        string GetFieldDescriptor(InterType fldType);
        string GetMethodDescriptor(InterMethod method);

        string GetAnonimousClassName();
        void WriteAnonumousClass(Java.Class javaClass);
        Java.Method GetAnonumousAccessMethod();
    }
}
