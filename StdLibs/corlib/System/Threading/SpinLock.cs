using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
    /// <summary>Provides a mutual exclusion lock primitive where a thread trying to acquire the lock waits in a loop repeatedly checking until the lock becomes available.</summary>
    [DebuggerDisplayAttribute("IsHeld = {IsHeld}")]
    [ComVisibleAttribute(false)]
    public struct SpinLock
    {
    
        /// <summary>Gets whether the lock is currently held by any thread.</summary><returns>true if the lock is currently held by any thread; otherwise false.</returns>
        public bool IsHeld
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether the lock is held by the current thread.</summary><returns>true if the lock is held by the current thread; otherwise false.</returns><exception cref="T:System.InvalidOperationException">Thread ownership tracking is disabled.</exception>
        public bool IsHeldByCurrentThread
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether thread ownership tracking is enabled for this instance.</summary><returns>true if thread ownership tracking is enabled for this instance; otherwise false.</returns>
        public bool IsThreadOwnerTrackingEnabled
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.SpinLock" /> structure with the option to track thread IDs to improve debugging.</summary><param name="enableThreadOwnerTracking">Whether to capture and use thread IDs for debugging purposes.</param>
        public SpinLock(bool enableThreadOwnerTracking)
        {
             throw new NotImplementedException();
        }
        
        
        public void Enter(ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        public void TryEnter(ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        public void TryEnter(TimeSpan timeout, ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public void Exit()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the lock.</summary><param name="useMemoryBarrier">A Boolean value that indicates whether a memory fence should be issued in order to immediately publish the exit operation to other threads.</param><exception cref="T:System.Threading.SynchronizationLockException">Thread ownership tracking is enabled, and the current thread is not the owner of this lock.</exception>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public void Exit(bool useMemoryBarrier)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
