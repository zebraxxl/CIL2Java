using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public interface IByRefController
    {
        Java.Constants.MethodRef GetByRefGetValueMethodRef(JavaPrimitiveType type);
        Java.Constants.MethodRef GetByRefSetValueMethodRef(JavaPrimitiveType type);

        string GetLocalByRefTypeName(InterType type);
        Java.Constants.MethodRef GetLocalByRefCtorMethodRef(InterType type);

        string GetFieldByRefTypeName(InterType type);
        Java.Constants.MethodRef GetFieldByRefCtorMethodRef(InterType type);
    }
}
