using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>When applied to an array parameter in a Windows Runtime component, specifies that the contents of the array that is passed to that parameter are used only for input. The caller expects the array to be unchanged by the call. See the Remarks section for important information about callers that are written using managed code. </summary>
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    public sealed class ReadOnlyArrayAttribute : Attribute
    {
        public ReadOnlyArrayAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
