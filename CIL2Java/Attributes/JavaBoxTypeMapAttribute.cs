using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in corlib
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Struct, Inherited = false)]
    public class JavaBoxTypeMapAttribute : Attribute
    {
        public Type JavaType { get; private set; }

        public JavaBoxTypeMapAttribute(Type javaType)
        {
            this.JavaType = javaType;
        }
    }
}
