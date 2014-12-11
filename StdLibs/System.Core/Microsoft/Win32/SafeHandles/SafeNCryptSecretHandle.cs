using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public sealed class SafeNCryptSecretHandle : SafeNCryptHandle
    {
        protected override bool ReleaseNativeHandle()
        {
             throw new NotImplementedException();
        }
        
        
        public SafeNCryptSecretHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
