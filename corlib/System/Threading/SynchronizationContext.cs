using System.Security;
using System.Runtime.ConstrainedExecution;
using System;

namespace System.Threading
{
    /// <summary>Provides the basic functionality for propagating a synchronization context in various synchronization models. </summary><filterpriority>2</filterpriority>
    public class SynchronizationContext
    {
    
        /// <summary>Gets the synchronization context for the current thread.</summary><returns>A <see cref="T:System.Threading.SynchronizationContext" /> object representing the current synchronization context.</returns><filterpriority>1</filterpriority>
        public static SynchronizationContext Current
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SynchronizationContext()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected void SetWaitNotificationRequired()
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsWaitNotificationRequired()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, dispatches a synchronous message to a synchronization context.</summary><param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param><param name="state">The object passed to the delegate. </param><exception cref="T:System.NotSupportedException">The method was called in a Windows Store app. The implementation of <see cref="T:System.Threading.SynchronizationContext" /> for Windows Store apps does not support the <see cref="M:System.Threading.SynchronizationContext.Send(System.Threading.SendOrPostCallback,System.Object)" /> method. </exception><filterpriority>2</filterpriority>
        public virtual void Send(SendOrPostCallback d, object state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, dispatches an asynchronous message to a synchronization context.</summary><param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param><param name="state">The object passed to the delegate.</param><filterpriority>2</filterpriority>
        public virtual void Post(SendOrPostCallback d, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void OperationStarted()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void OperationCompleted()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any or all the elements in the specified array to receive a signal.</summary><returns>The array index of the object that satisfied the wait.</returns><param name="waitHandles">An array of type <see cref="T:System.IntPtr" /> that contains the native operating system handles.</param><param name="waitAll">true to wait for all handles; false to wait for any handle. </param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><exception cref="T:System.ArgumentNullException"><paramref name="waitHandles" /> is null.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [PrePrepareMethodAttribute()]
        public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Helper function that waits for any or all the elements in the specified array to receive a signal.</summary><returns>The array index of the object that satisfied the wait.</returns><param name="waitHandles">An array of type <see cref="T:System.IntPtr" /> that contains the native operating system handles.</param><param name="waitAll">true to wait for all handles;  false to wait for any handle. </param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        [PrePrepareMethodAttribute()]
        protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the current synchronization context.</summary><param name="syncContext">The <see cref="T:System.Threading.SynchronizationContext" /> object to be set.</param><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void SetSynchronizationContext(SynchronizationContext syncContext)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual SynchronizationContext CreateCopy()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
