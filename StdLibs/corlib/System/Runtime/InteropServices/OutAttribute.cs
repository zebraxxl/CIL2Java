using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that data should be marshaled from callee back to caller.</summary>
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class OutAttribute : Attribute
    {
        public OutAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
