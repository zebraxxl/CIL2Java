using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in corlib
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Delegate | AttributeTargets.Method, Inherited = false)]
    public class MethodMapAttribute : Attribute
    {
        public Type Class { get; private set; }
        public string Name { get; private set; }
        public bool ForceStatic { get; private set; }

        public MethodMapAttribute(Type Class, string Name)
        {
            this.Class = Class;
            this.Name = Name;
            this.ForceStatic = false;
        }

        public MethodMapAttribute(Type Class, string Name, bool ForceStatic)
        {
            this.Class = Class;
            this.Name = Name;
            this.ForceStatic = ForceStatic;
        }
    }
}
