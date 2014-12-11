using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates that a method is an extension method, or that a class or assembly contains extension methods.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute
    {
        public ExtensionAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
