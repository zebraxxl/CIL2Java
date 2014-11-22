using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that the HRESULT or retval signature transformation that takes place during COM interop calls should be suppressed.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    public sealed class PreserveSigAttribute : Attribute
    {
        public PreserveSigAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
