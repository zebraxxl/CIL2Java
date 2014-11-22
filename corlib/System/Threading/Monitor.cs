using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System;

namespace System.Threading
{
    /// <summary>Provides a mechanism that synchronizes access to objects.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public static class Monitor
    {
        /// <summary>Acquires an exclusive lock on the specified object.</summary><param name="obj">The object on which to acquire the monitor lock. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void Enter(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Enter(object obj, ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases an exclusive lock on the specified object.</summary><param name="obj">The object on which to release the lock. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">The current thread does not own the lock for the specified object. </exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static void Exit(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts to acquire an exclusive lock on the specified object.</summary><returns>true if the current thread acquires the lock; otherwise, false.</returns><param name="obj">The object on which to acquire the lock. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><filterpriority>1</filterpriority>
        public static bool TryEnter(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public static void TryEnter(object obj, ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts, for the specified number of milliseconds, to acquire an exclusive lock on the specified object.</summary><returns>true if the current thread acquires the lock; otherwise, false.</returns><param name="obj">The object on which to acquire the lock. </param><param name="millisecondsTimeout">The number of milliseconds to wait for the lock. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is negative, and not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception><filterpriority>1</filterpriority>
        public static bool TryEnter(object obj, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts, for the specified amount of time, to acquire an exclusive lock on the specified object.</summary><returns>true if the current thread acquires the lock without blocking; otherwise, false.</returns><param name="obj">The object on which to acquire the lock. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> representing the amount of time to wait for the lock. A value of –1 millisecond specifies an infinite wait.</param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> in milliseconds is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> (–1 millisecond), or is greater than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static bool TryEnter(object obj, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current thread holds the lock on the specified object. </summary><returns>true if the current thread holds the lock on <paramref name="obj" />; otherwise, false.</returns><param name="obj">The object to test. </param><exception cref="T:System.ArgumentNullException"><paramref name="obj" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public static bool IsEntered(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue. This method also specifies whether the synchronization domain for the context (if in a synchronized context) is exited before the wait and reacquired afterward.</summary><returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns><param name="obj">The object on which to wait. </param><param name="millisecondsTimeout">The number of milliseconds to wait before the thread enters the ready queue. </param><param name="exitContext">true to exit and reacquire the synchronization domain for the context (if in a synchronized context) before the wait; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">Wait is not invoked from within a synchronized block of code. </exception><exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="millisecondsTimeout" /> parameter is negative, and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue. Optionally exits the synchronization domain for the synchronized context before the wait and reacquires the domain afterward.</summary><returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns><param name="obj">The object on which to wait. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> representing the amount of time to wait before the thread enters the ready queue. </param><param name="exitContext">true to exit and reacquire the synchronization domain for the context (if in a synchronized context) before the wait; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">Wait is not invoked from within a synchronized block of code. </exception><exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is negative and does not represent <see cref="F:System.Threading.Timeout.Infinite" /> (–1 millisecond), or is greater than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static bool Wait(object obj, TimeSpan timeout, bool exitContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue.</summary><returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns><param name="obj">The object on which to wait. </param><param name="millisecondsTimeout">The number of milliseconds to wait before the thread enters the ready queue. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception><exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="millisecondsTimeout" /> parameter is negative, and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception><filterpriority>1</filterpriority>
        public static bool Wait(object obj, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue.</summary><returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns><param name="obj">The object on which to wait. </param><param name="timeout">A <see cref="T:System.TimeSpan" /> representing the amount of time to wait before the thread enters the ready queue. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception><exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="timeout" /> parameter in milliseconds is negative and does not represent <see cref="F:System.Threading.Timeout.Infinite" /> (–1 millisecond), or is greater than <see cref="F:System.Int32.MaxValue" />. </exception><filterpriority>1</filterpriority>
        public static bool Wait(object obj, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock.</summary><returns>true if the call returned because the caller reacquired the lock for the specified object. This method does not return if the lock is not reacquired.</returns><param name="obj">The object on which to wait. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception><exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception><filterpriority>1</filterpriority>
        public static bool Wait(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Notifies a thread in the waiting queue of a change in the locked object's state.</summary><param name="obj">The object a thread is waiting for. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void Pulse(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Notifies all waiting threads of a change in the object's state.</summary><param name="obj">The object that sends the pulse. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void PulseAll(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
