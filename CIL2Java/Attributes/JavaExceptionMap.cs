using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in corlib
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class JavaExceptionMapAttribute : Attribute
    {
        public string JavaException { get; private set; }

        public JavaExceptionMapAttribute(string javaException)
        {
            this.JavaException = javaException;
        }
    }
}
