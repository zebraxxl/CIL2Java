using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Delegate | AttributeTargets.Method, Inherited = false)]
    public class JavaBoxMethodMapAttribute : Attribute
    {
        public Type Class { get; private set; }
        public string Name { get; private set; }
        public bool ForceStatic { get; private set; }

        public JavaBoxMethodMapAttribute(Type Class, string Name)
        {
            this.Class = Class;
            this.Name = Name;
            this.ForceStatic = false;
        }

        public JavaBoxMethodMapAttribute(Type Class, string Name, bool ForceStatic)
        {
            this.Class = Class;
            this.Name = Name;
            this.ForceStatic = ForceStatic;
        }
    }
}
