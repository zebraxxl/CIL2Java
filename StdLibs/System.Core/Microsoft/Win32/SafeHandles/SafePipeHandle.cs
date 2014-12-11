using System.Security;
using System;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public sealed class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafePipeHandle(IntPtr preexistingHandle, bool ownsHandle)
            : base(ownsHandle)
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool ReleaseHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
