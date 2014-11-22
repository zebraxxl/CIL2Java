using System.Security;
using System.Runtime.ConstrainedExecution;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Represents a wrapper class for handle resources.</summary>
    [SecurityCriticalAttribute()]
    public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable
    {
        /// <summary>Specifies the handle to be wrapped.</summary>
        protected IntPtr handle;
    
        /// <summary>Gets a value indicating whether the handle is closed.</summary><returns>true if the handle is closed; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public bool IsClosed
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets a value indicating whether the handle value is invalid.</summary><returns>true if the handle is valid; otherwise, false.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public abstract bool IsInvalid
        {
            get;
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.CriticalHandle" /> class with the specified invalid handle value.</summary><param name="invalidHandleValue">The value of an invalid handle (usually 0 or -1).</param><exception cref="T:System.TypeLoadException">The derived class resides in an assembly without unmanaged code access permission.</exception>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected CriticalHandle(IntPtr invalidHandleValue)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        ~CriticalHandle()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the handle to the specified pre-existing handle.</summary><param name="handle">The pre-existing handle to use.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        protected void SetHandle(IntPtr handle)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Runtime.InteropServices.CriticalHandle" /> class specifying whether to perform a normal dispose operation.</summary><param name="disposing">true for a normal dispose operation; false to finalize the handle.</param>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public void SetHandleAsInvalid()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        protected abstract bool ReleaseHandle();
        
        
    }
}
