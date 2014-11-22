using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that information was lost about a class or interface when it was imported from a type library to an assembly.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = false)]
    public sealed class ComConversionLossAttribute : Attribute
    {
        public ComConversionLossAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
