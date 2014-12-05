using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    public class InterfacesMapAttribute : Attribute
    {
        public Type InterfacesType { get; private set; }

        public InterfacesMapAttribute(Type interfacesType)
        {
            this.InterfacesType = interfacesType;
        }
    }
}
