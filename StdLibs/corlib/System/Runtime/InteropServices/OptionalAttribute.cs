using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that a parameter is optional.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false)]
    public sealed class OptionalAttribute : Attribute
    {
        public OptionalAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
