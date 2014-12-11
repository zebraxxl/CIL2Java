using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that data should be marshaled from the caller to the callee, but not back to the caller.</summary>
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class InAttribute : Attribute
    {
        public InAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
