using System.Security;
using System.Runtime.ConstrainedExecution;
using System;

namespace Microsoft.Win32.SafeHandles
{
    /// <summary>Represents a wrapper class for a wait handle. </summary>
    [SecurityCriticalAttribute()]
    public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" /> class. </summary><param name="existingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param><param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
            : base(ownsHandle)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected override bool ReleaseHandle()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
