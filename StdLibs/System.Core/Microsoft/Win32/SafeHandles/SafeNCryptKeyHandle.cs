using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public sealed class SafeNCryptKeyHandle : SafeNCryptHandle
    {
        protected override bool ReleaseNativeHandle()
        {
             throw new NotImplementedException();
        }
        
        
        public SafeNCryptKeyHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
