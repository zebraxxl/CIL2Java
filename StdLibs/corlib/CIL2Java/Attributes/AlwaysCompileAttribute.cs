using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class AlwaysCompileAttribute : Attribute
    {
        public AlwaysCompileAttribute()
        {
        }
    }
}
