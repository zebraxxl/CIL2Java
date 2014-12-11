using System.Security;
using System.Runtime.InteropServices;
using System;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public sealed class SafeMemoryMappedViewHandle : SafeBuffer
    {
        internal SafeMemoryMappedViewHandle()
            : base(false)
        {}

        protected override bool ReleaseHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
