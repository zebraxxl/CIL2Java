using System.Runtime.InteropServices;
using System.Diagnostics;
using System;

namespace System.Threading
{
    /// <summary>Provides a slimmed down version of <see cref="T:System.Threading.ManualResetEvent" />.</summary>
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Set = {IsSet}")]
    public class ManualResetEventSlim : IDisposable
    {
    
        /// <summary>Gets the underlying <see cref="T:System.Threading.WaitHandle" /> object for this <see cref="T:System.Threading.ManualResetEventSlim" />.</summary><returns>The underlying <see cref="T:System.Threading.WaitHandle" /> event object fore this <see cref="T:System.Threading.ManualResetEventSlim" />.</returns>
        public WaitHandle WaitHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether the event is set.</summary><returns>true if the event has is set; otherwise, false.</returns>
        public bool IsSet
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of spin waits that will be occur before falling back to a kernel-based wait operation.</summary><returns>Returns the number of spin waits that will be occur before falling back to a kernel-based wait operation.</returns>
        public int SpinCount
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ManualResetEventSlim()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class with a Boolean value indicating whether to set the intial state to signaled.</summary><param name="initialState">true to set the initial state signaled; false to set the initial state to nonsignaled.</param>
        public ManualResetEventSlim(bool initialState)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class with a Boolean value indicating whether to set the intial state to signaled and a specified spin count.</summary><param name="initialState">true to set the initial state to signaled; false to set the initial state to nonsignaled.</param><param name="spinCount">The number of spin waits that will occur before falling back to a kernel-based wait operation.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="spinCount" /> is less than 0 or greater than the maximum allowed value.</exception>
        public ManualResetEventSlim(bool initialState, int spinCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void Set()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        public void Wait()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> receives a signal, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ObjectDisposedException">The object has already been disposed or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
        public void Wait(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set, using a <see cref="T:System.TimeSpan" /> to measure the time interval.</summary><returns>true if the <see cref="T:System.Threading.ManualResetEventSlim" /> was set; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception><exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
        public bool Wait(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set, using a <see cref="T:System.TimeSpan" /> to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>true if the <see cref="T:System.Threading.ManualResetEventSlim" /> was set; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded. </exception><exception cref="T:System.ObjectDisposedException">The object has already been disposed or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
        public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set, using a 32-bit signed integer to measure the time interval.</summary><returns>true if the <see cref="T:System.Threading.ManualResetEventSlim" /> was set; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception><exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
        public bool Wait(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set, using a 32-bit signed integer to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>true if the <see cref="T:System.Threading.ManualResetEventSlim" /> was set; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception><exception cref="T:System.ObjectDisposedException">The object has already been disposed or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.ManualResetEventSlim" />, and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
