using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class Compiler
    {
        string INamesController.TypeNameToJava(InterType CILName)
        {
            if (CILName.IsArray)
                return GetFieldDescriptor(CILName);
            else if (CILName.IsByRef)
                return TypeNameToJava(GetByRefTypeName(CILName));
            
            return TypeNameToJava(CILName.Fullname);
        }

        string INamesController.TypeNameToJava(string CILName)
        {
            return TypeNameToJava(CILName);
        }

        string INamesController.FieldNameToJava(string CILName)
        {
            return FieldNameToJava(CILName);
        }

        string INamesController.MethodNameToJava(string CILName)
        {
            return MethodNameToJava(CILName);
        }

        string INamesController.GetFieldDescriptor(InterType fldType)
        {
            return GetFieldDescriptor(fldType);
        }

        string INamesController.GetMethodDescriptor(InterMethod method)
        {
            return GetMethodDescriptor(method);
        }

        string INamesController.GetAnonimousClassName()
        {
            throw new NotImplementedException();
        }

        void INamesController.WriteAnonumousClass(Java.Class javaClass)
        {
            throw new NotImplementedException();
        }

        Java.Method INamesController.GetAnonumousAccessMethod()
        {
            throw new NotImplementedException();
        }
    }
}
