using System.Runtime.InteropServices;
using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
    /// <summary>A lightweight alternative to <see cref="T:System.Threading.Semaphore" /> that limits the number of threads that can access a resource or pool of resources concurrently.</summary>
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Current Count = {m_currentCount}")]
    public class SemaphoreSlim : IDisposable
    {
    
        /// <summary>Gets the number of threads that will be allowed to enter the <see cref="T:System.Threading.SemaphoreSlim" />.</summary><returns>The current count of the <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
        public int CurrentCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns a <see cref="T:System.Threading.WaitHandle" /> that can be used to wait on the semaphore.</summary><returns>A <see cref="T:System.Threading.WaitHandle" /> that can be used to wait on the semaphore.</returns><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.SemaphoreSlim" /> has been disposed.</exception>
        public WaitHandle AvailableWaitHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreSlim" /> class, specifying the initial number of requests that can be granted concurrently.</summary><param name="initialCount">The initial number of requests for the semaphore that can be granted concurrently.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="initialCount" /> is less than 0.</exception>
        public SemaphoreSlim(int initialCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreSlim" /> class, specifying the initial and maximum number of requests that can be granted concurrently.</summary><param name="initialCount">The initial number of requests for the semaphore that can be granted concurrently.</param><param name="maxCount">The maximum number of requests for the semaphore that can be granted concurrently.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="initialCount" /> is less than 0, or <paramref name="initialCount" /> is greater than <paramref name="maxCount" />, or <paramref name="maxCount" /> is equal to or less than 0.</exception>
        public SemaphoreSlim(int initialCount, int maxCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void Wait()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> token to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
        public void Wait(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a <see cref="T:System.TimeSpan" /> to specify the timeout.</summary><returns>true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.ObjectDisposedException">The semaphoreSlim instance has been disposed<paramref name="." /></exception>
        public bool Wait(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a <see cref="T:System.TimeSpan" /> that specifies the timeout, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.ObjectDisposedException">The semaphoreSlim instance has been disposed<paramref name="." /><paramref name="-or-" />The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
        public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer that specifies the timeout.</summary><returns>true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
        public bool Wait(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer that specifies the timeout, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.OperationCanceledException"><paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.SemaphoreSlim" /> instance has been disposed, or the <see cref="T:System.Threading.CancellationTokenSource" />that created<paramref name=" cancellationToken" /> has been disposed.</exception>
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task WaitAsync()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>A task that will complete when the semaphore has been entered.</returns><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> token to observe.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
        public Task WaitAsync(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer to measure the time interval.</summary><returns>A task that will complete with a result of true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />, otherwise with a result of false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
        public Task<bool> WaitAsync(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a <see cref="T:System.TimeSpan" /> to measure the time interval.</summary><returns>A task that will complete with a result of true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />, otherwise with a result of false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public Task<bool> WaitAsync(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a <see cref="T:System.TimeSpan" /> to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>A task that will complete with a result of true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />, otherwise with a result of false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> token to observe.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out-or-timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary><returns>A task that will complete with a result of true if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />, otherwise with a result of false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
        public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public int Release()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exits the <see cref="T:System.Threading.SemaphoreSlim" /> a specified number of times.</summary><returns>The previous count of the <see cref="T:System.Threading.SemaphoreSlim" />.</returns><param name="releaseCount">The number of times to exit the semaphore.</param><exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="releaseCount" /> is less than 1.</exception><exception cref="T:System.Threading.SemaphoreFullException">The <see cref="T:System.Threading.SemaphoreSlim" /> has already reached its maximum size.</exception>
        public int Release(int releaseCount)
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
