using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    [AttributeUsage(AttributeTargets.Field, Inherited = false)]
    public class FieldMapAttribute : Attribute
    {
        public Type Class { get; private set; }
        public string Name { get; private set; }

        public FieldMapAttribute(Type Class)
        {
            this.Class = Class;
            this.Name = null;
        }

        public FieldMapAttribute(Type Class, string Name)
        {
            this.Class = Class;
            this.Name = Name;
        }
    }
}
