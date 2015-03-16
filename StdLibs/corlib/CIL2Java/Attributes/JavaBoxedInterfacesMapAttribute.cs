using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    public class JavaBoxedInterfacesMapAttribute : Attribute
    {
        public Type InterfacesType { get; private set; }

        public JavaBoxedInterfacesMapAttribute(Type interfacesType)
        {
            this.InterfacesType = interfacesType;
        }
    }
}
