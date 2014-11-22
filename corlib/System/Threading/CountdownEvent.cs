using System.Diagnostics;
using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Represents a synchronization primitive that is signaled when its count reaches zero.</summary>
    [DebuggerDisplayAttribute("Initial Count={InitialCount}, Current Count={CurrentCount}")]
    [ComVisibleAttribute(false)]
    public class CountdownEvent : IDisposable
    {
    
        /// <summary>Gets the number of remaining signals required to set the event.</summary><returns> The number of remaining signals required to set the event.</returns>
        public int CurrentCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the numbers of signals initially required to set the event.</summary><returns> The number of signals initially required to set the event.</returns>
        public int InitialCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines whether the event is set.</summary><returns>true if the event is set; otherwise, false.</returns>
        public bool IsSet
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for the event to be set.</summary><returns>A <see cref="T:System.Threading.WaitHandle" /> that is used to wait for the event to be set.</returns><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
        public WaitHandle WaitHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of <see cref="T:System.Threading.CountdownEvent" /> class with the specified count.</summary><param name="initialCount">The number of signals initially required to set the <see cref="T:System.Threading.CountdownEvent" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="initialCount" /> is less than 0.</exception>
        public CountdownEvent(int initialCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.CountdownEvent" />, and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Signal()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers multiple signals with the <see cref="T:System.Threading.CountdownEvent" />, decrementing the value of <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> by the specified amount.</summary><returns>true if the signals caused the count to reach zero and the event was set; otherwise, false.</returns><param name="signalCount">The number of signals to register.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="signalCount" /> is less than 1.</exception><exception cref="T:System.InvalidOperationException">The current instance is already set. -or- Or <paramref name="signalCount" /> is greater than <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</exception>
        public bool Signal(int signalCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddCount()
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryAddCount()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Increments the <see cref="T:System.Threading.CountdownEvent" />'s current count by a specified value.</summary><param name="signalCount">The value by which to increase <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="signalCount" /> is less than or equal to 0.</exception><exception cref="T:System.InvalidOperationException">The current instance is already set.-or-<see cref="P:System.Threading.CountdownEvent.CurrentCount" /> is equal to or greater than <see cref="F:System.Int32.MaxValue" /> after count is incremented by <paramref name="signalCount." /></exception>
        public void AddCount(int signalCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts to increment <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> by a specified value.</summary><returns>true if the increment succeeded; otherwise, false. If <see cref="P:System.Threading.CountdownEvent.CurrentCount" /> is already at zero this will return false.</returns><param name="signalCount">The value by which to increase <see cref="P:System.Threading.CountdownEvent.CurrentCount" />.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="signalCount" /> is less than or equal to 0.</exception><exception cref="T:System.InvalidOperationException">The current instance is already set.-or-<see cref="P:System.Threading.CountdownEvent.CurrentCount" /> + <paramref name="signalCount" /> is equal to or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public bool TryAddCount(int signalCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resets the <see cref="P:System.Threading.CountdownEvent.InitialCount" /> property to a specified value.</summary><param name="count">The number of signals required to set the <see cref="T:System.Threading.CountdownEvent" />.</param><exception cref="T:System.ObjectDisposedException">The current instance has alread been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than 0.</exception>
        public void Reset(int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void Wait()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the <see cref="T:System.Threading.CountdownEvent" /> is set, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> has been canceled.</exception><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. -or- The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
        public void Wait(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the <see cref="T:System.Threading.CountdownEvent" /> is set, using a <see cref="T:System.TimeSpan" /> to measure the timeout.</summary><returns>true if the <see cref="T:System.Threading.CountdownEvent" /> was set; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public bool Wait(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the <see cref="T:System.Threading.CountdownEvent" /> is set, using a <see cref="T:System.TimeSpan" /> to measure the timeout, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>true if the <see cref="T:System.Threading.CountdownEvent" /> was set; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> has been canceled.</exception><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. -or- The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the <see cref="T:System.Threading.CountdownEvent" /> is set, using a 32-bit signed integer to measure the timeout.</summary><returns>true if the <see cref="T:System.Threading.CountdownEvent" /> was set; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
        public bool Wait(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the <see cref="T:System.Threading.CountdownEvent" /> is set, using a 32-bit signed integer to measure the timeout, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>true if the <see cref="T:System.Threading.CountdownEvent" /> was set; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> has been canceled.</exception><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. -or- The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
