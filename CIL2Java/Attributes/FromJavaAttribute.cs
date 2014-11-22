using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in corlib
    [AttributeUsage(AttributeTargets.All)]
    public sealed class FromJavaAttribute : Attribute
    {
        public string JavaName { get; private set; }

        public FromJavaAttribute()
        {
            JavaName = null;
        }

        public FromJavaAttribute(string javaName)
        {
            JavaName = javaName;
        }
    }
}
