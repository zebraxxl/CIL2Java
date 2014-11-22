using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Allows an unmanaged method to call a managed method.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class AllowReversePInvokeCallsAttribute : Attribute
    {
        public AllowReversePInvokeCallsAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
