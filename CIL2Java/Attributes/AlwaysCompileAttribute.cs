using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in corlib
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class AlwaysCompileAttribute : Attribute
    {
        public AlwaysCompileAttribute()
        {
        }
    }
}
