using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Signals to a <see cref="T:System.Threading.CancellationToken" /> that it should be canceled.</summary>
    [ComVisibleAttribute(false)]
    public class CancellationTokenSource : IDisposable
    {
    
        /// <summary>Gets whether cancellation has been requested for this <see cref="T:System.Threading.CancellationTokenSource" />.</summary><returns>Whether cancellation has been requested for this <see cref="T:System.Threading.CancellationTokenSource" />.</returns>
        public bool IsCancellationRequested
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.CancellationTokenSource" />.</summary><returns>The <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.CancellationTokenSource" />.</returns><exception cref="T:System.ObjectDisposedException">The token source has been disposed.</exception>
        public CancellationToken Token
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CancellationTokenSource()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a <see cref="T:System.Threading.CancellationTokenSource" /> that will be canceled after a specified time span.</summary><param name="delay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when <paramref name="delay" /> is less than -1 or greater than Int32.MaxValue.</exception>
        public CancellationTokenSource(TimeSpan delay)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Constructs a <see cref="T:System.Threading.CancellationTokenSource" /> that will be canceled after a specified time span.</summary><param name="millisecondsDelay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when <paramref name="millisecondsDelay" /> is less than -1.</exception>
        public CancellationTokenSource(int millisecondsDelay)
        {
             throw new NotImplementedException();
        }
        
        
        public void Cancel()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Communicates a request for cancellation.</summary><param name="throwOnFirstException">Specifies whether exceptions should immediately propagate.</param><exception cref="T:System.ObjectDisposedException">This <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception><exception cref="T:System.AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated <see cref="T:System.Threading.CancellationToken" />.</exception>
        public void Cancel(bool throwOnFirstException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Schedules a Cancel operation on this <see cref="T:System.Threading.CancellationTokenSource" />.</summary><param name="delay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param><exception cref="T:System.ObjectDisposedException">The exception thrown when this <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when <paramref name="delay" /> is less than -1 or greater than Int32.MaxValue.</exception>
        public void CancelAfter(TimeSpan delay)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Schedules a Cancel operation on this <see cref="T:System.Threading.CancellationTokenSource" />.</summary><param name="millisecondsDelay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param><exception cref="T:System.ObjectDisposedException">The exception thrown when this <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException">The exception thrown when <paramref name="millisecondsDelay" /> is less than -1.</exception>
        public void CancelAfter(int millisecondsDelay)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.CancellationTokenSource" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Threading.CancellationTokenSource" /> that will be in the canceled state when any of the source tokens are in the canceled state.</summary><returns>A <see cref="T:System.Threading.CancellationTokenSource" /> that is linked to the source tokens.</returns><param name="token1">The first <see cref="T:System.Threading.CancellationToken" /> to observe.</param><param name="token2">The second <see cref="T:System.Threading.CancellationToken" /> to observe.</param><exception cref="T:System.ObjectDisposedException">A <see cref="T:System.Threading.CancellationTokenSource" /> associated with one of the source tokens has been disposed.</exception><exception cref="T:System.ArgumentException">If any of the tokens cannot be canceled, they will not be linked. The returned source will be cancelable.-or-If any of the tokens are already canceled then the linked token will be returned in canceled state.</exception>
        public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Threading.CancellationTokenSource" /> that will be in the canceled state when any of the source tokens are in the canceled state.</summary><returns>A <see cref="T:System.Threading.CancellationTokenSource" /> that is linked to the source tokens.</returns><param name="tokens">The <see cref="T:System.Threading.CancellationToken" /> instances to observe.</param><exception cref="T:System.ObjectDisposedException">A <see cref="T:System.Threading.CancellationTokenSource" /> associated with one of the source tokens has been disposed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="tokens" /> is null.</exception><exception cref="T:System.ArgumentException">If any of the tokens cannot be canceled, they will not be linked. The returned source will be cancelable.-or-If any of the tokens are already canceled then the linked token will be returned in canceled state.</exception>
        public static CancellationTokenSource CreateLinkedTokenSource(params  CancellationToken[] tokens)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
