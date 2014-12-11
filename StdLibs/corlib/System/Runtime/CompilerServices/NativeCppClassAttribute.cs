using System.Runtime.InteropServices;
using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Applies metadata to an assembly that indicates that a type is an unmanaged type.  This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Struct, Inherited = true)]
    public sealed class NativeCppClassAttribute : Attribute
    {
        public NativeCppClassAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
