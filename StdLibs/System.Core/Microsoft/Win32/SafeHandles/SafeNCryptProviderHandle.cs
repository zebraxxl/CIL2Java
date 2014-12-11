using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public sealed class SafeNCryptProviderHandle : SafeNCryptHandle
    {
        protected override bool ReleaseNativeHandle()
        {
             throw new NotImplementedException();
        }
        
        
        public SafeNCryptProviderHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
