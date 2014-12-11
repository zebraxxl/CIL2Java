using System.Security;
using System.Runtime.ConstrainedExecution;
using System;

namespace Microsoft.Win32.SafeHandles
{
    [SecurityCriticalAttribute(SecurityCriticalScope.Everything)]
    public abstract class SafeNCryptHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
    
    
        protected SafeNCryptHandle()
            : base(false)
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool ReleaseHandle()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        protected abstract bool ReleaseNativeHandle();
        
        
    }
}
