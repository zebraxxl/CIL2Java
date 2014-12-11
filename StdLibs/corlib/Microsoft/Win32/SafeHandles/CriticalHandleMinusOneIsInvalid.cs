using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System;

namespace Microsoft.Win32.SafeHandles
{
    /// <summary>Provides a base class for Win32 critical handle implementations in which the value of -1 indicates an invalid handle.</summary>
    [SecurityCriticalAttribute()]
    public abstract class CriticalHandleMinusOneIsInvalid : CriticalHandle
    {
        /// <summary>Gets a value that indicates whether the handle is invalid.</summary><returns>true if the handle is not valid; otherwise, false.</returns>
        public override bool IsInvalid
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected CriticalHandleMinusOneIsInvalid()
            : base(IntPtr.Zero)
        {
            throw new NotImplementedException();
        }
        
        
    }
}
