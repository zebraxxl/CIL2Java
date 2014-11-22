using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System;

namespace System.Threading
{
    /// <summary>Defines a lock that supports single writers and multiple readers. </summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public sealed class ReaderWriterLock : CriticalFinalizerObject
    {
    
        /// <summary>Gets a value indicating whether the current thread holds a reader lock.</summary><returns>true if the current thread holds a reader lock; otherwise, false.</returns><filterpriority>2</filterpriority>
        public bool IsReaderLockHeld
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current thread holds the writer lock.</summary><returns>true if the current thread holds the writer lock; otherwise, false.</returns><filterpriority>2</filterpriority>
        public bool IsWriterLockHeld
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current sequence number.</summary><returns>The current sequence number.</returns><filterpriority>2</filterpriority>
        public int WriterSeqNum
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public ReaderWriterLock()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        ~ReaderWriterLock()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires a reader lock, using an <see cref="T:System.Int32" /> value for the time-out.</summary><param name="millisecondsTimeout">The time-out in milliseconds. </param><exception cref="T:System.ApplicationException"><paramref name="millisecondsTimeout" /> expires before the lock request is granted. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void AcquireReaderLock(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires a reader lock, using a <see cref="T:System.TimeSpan" /> value for the time-out.</summary><param name="timeout">A TimeSpan specifying the time-out period. </param><exception cref="T:System.ApplicationException"><paramref name="timeout" /> expires before the lock request is granted. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> specifies a negative value other than -1 milliseconds. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void AcquireReaderLock(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires the writer lock, using an <see cref="T:System.Int32" /> value for the time-out.</summary><param name="millisecondsTimeout">The time-out in milliseconds. </param><exception cref="T:System.ApplicationException"><paramref name="timeout" /> expires before the lock request is granted. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void AcquireWriterLock(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Acquires the writer lock, using a <see cref="T:System.TimeSpan" /> value for the time-out.</summary><param name="timeout">The TimeSpan specifying the time-out period. </param><exception cref="T:System.ApplicationException"><paramref name="timeout" /> expires before the lock request is granted. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> specifies a negative value other than -1 milliseconds. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void AcquireWriterLock(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public void ReleaseReaderLock()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public void ReleaseWriterLock()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Upgrades a reader lock to the writer lock, using an Int32 value for the time-out.</summary><returns>A <see cref="T:System.Threading.LockCookie" /> value.</returns><param name="millisecondsTimeout">The time-out in milliseconds. </param><exception cref="T:System.ApplicationException"><paramref name="millisecondsTimeout" /> expires before the lock request is granted. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public LockCookie UpgradeToWriterLock(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Upgrades a reader lock to the writer lock, using a TimeSpan value for the time-out.</summary><returns>A <see cref="T:System.Threading.LockCookie" /> value.</returns><param name="timeout">The TimeSpan specifying the time-out period. </param><exception cref="T:System.ApplicationException"><paramref name="timeout" /> expires before the lock request is granted. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> specifies a negative value other than -1 milliseconds. </exception><filterpriority>2</filterpriority>
        public LockCookie UpgradeToWriterLock(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void DowngradeFromWriterLock(ref LockCookie lockCookie)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public LockCookie ReleaseLock()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void RestoreLock(ref LockCookie lockCookie)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the writer lock has been granted to any thread since the sequence number was obtained.</summary><returns>true if the writer lock has been granted to any thread since the sequence number was obtained; otherwise, false.</returns><param name="seqNum">The sequence number. </param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public bool AnyWritersSince(int seqNum)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
