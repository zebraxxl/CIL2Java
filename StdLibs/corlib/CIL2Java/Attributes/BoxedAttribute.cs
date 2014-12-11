using System;
using System.Collections.Generic;

namespace CIL2Java.Attributes
{
    //Dublicate in CIL2Java
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
    public sealed class BoxedAttribute : Attribute
    {
        public BoxedAttribute()
        {
        }
    }
}
