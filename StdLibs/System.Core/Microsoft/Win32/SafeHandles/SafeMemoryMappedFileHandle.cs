using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public sealed class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        internal SafeMemoryMappedFileHandle()
            : base(false)
        {

        }

        protected override bool ReleaseHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
