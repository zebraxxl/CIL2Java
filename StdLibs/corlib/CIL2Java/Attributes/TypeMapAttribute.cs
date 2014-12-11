using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Struct, Inherited = false)]
    public class TypeMapAttribute : Attribute
    {
        public Type JavaType { get; private set; }

        public TypeMapAttribute(Type javaType)
        {
            this.JavaType = javaType;
        }
    }
}
