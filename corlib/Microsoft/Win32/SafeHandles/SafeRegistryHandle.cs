using System.Security;
using System;

namespace Microsoft.Win32.SafeHandles
{
    /// <summary>Represents a safe handle to the Windows registry.</summary>
    [SecurityCriticalAttribute()]
    public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        /// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeRegistryHandle" /> class. </summary><param name="preexistingHandle">An object that represents the pre-existing handle to use.</param><param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent reliable release.</param>
        [SecurityCriticalAttribute()]
        public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle)
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
