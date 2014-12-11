using System;

namespace System.Runtime.InteropServices
{
    /// <summary>This attribute has been deprecated. </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    [ObsoleteAttribute("This attribute has been deprecated.  Application Domains no longer respect Activation Context boundaries in IDispatch calls.", false)]
    public sealed class SetWin32ContextInIDispatchAttribute : Attribute
    {
        public SetWin32ContextInIDispatchAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
