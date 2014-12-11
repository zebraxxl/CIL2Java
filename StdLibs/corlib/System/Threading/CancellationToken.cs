using System.Diagnostics;
using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Propagates notification that operations should be canceled.</summary>
    [DebuggerDisplayAttribute("IsCancellationRequested = {IsCancellationRequested}")]
    [ComVisibleAttribute(false)]
    public struct CancellationToken
    {
    
        /// <summary>Returns an empty CancellationToken value.</summary><returns>Returns an empty CancellationToken value.</returns>
        public static CancellationToken None
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether cancellation has been requested for this token.</summary><returns>true if cancellation has been requested for this token; otherwise false.</returns>
        public bool IsCancellationRequested
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether this token is capable of being in the canceled state.</summary><returns>true if this token is capable of being in the canceled state; otherwise false.</returns>
        public bool CanBeCanceled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that is signaled when the token is canceled.</summary><returns>A <see cref="T:System.Threading.WaitHandle" /> that is signaled when the token is canceled.</returns><exception cref="T:System.ObjectDisposedException">The associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
        public WaitHandle WaitHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes the <see cref="T:System.Threading.CancellationToken" />.</summary><param name="canceled">The canceled state for the token.</param>
        public CancellationToken(bool canceled)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a delegate that will be called when this <see cref="T:System.Threading.CancellationToken" /> is canceled.</summary><returns>The <see cref="T:System.Threading.CancellationTokenRegistration" /> instance that can be used to deregister the callback.</returns><param name="callback">The delegate to be executed when the <see cref="T:System.Threading.CancellationToken" /> is canceled.</param><exception cref="T:System.ObjectDisposedException">The associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="callback" /> is null.</exception>
        public CancellationTokenRegistration Register(Action callback)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a delegate that will be called when this <see cref="T:System.Threading.CancellationToken" /> is canceled.</summary><returns>The <see cref="T:System.Threading.CancellationTokenRegistration" /> instance that can be used to deregister the callback.</returns><param name="callback">The delegate to be executed when the <see cref="T:System.Threading.CancellationToken" /> is canceled.</param><param name="useSynchronizationContext">A Boolean value that indicates whether to capture the current <see cref="T:System.Threading.SynchronizationContext" /> and use it when invoking the <paramref name="callback" />.</param><exception cref="T:System.ObjectDisposedException">The associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="callback" /> is null.</exception>
        public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext)
        {
             throw new NotImplementedException();
        }
        
        
        public CancellationTokenRegistration Register(Action<object> callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.Threading.CancellationToken" /> instance is equal to the specified token.</summary><returns>True if the instances are equal; otherwise, false. Two tokens are equal if they are associated with the same <see cref="T:System.Threading.CancellationTokenSource" /> or if they were both constructed from public CancellationToken constructors and their <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> values are equal.</returns><param name="other">The other <see cref="T:System.Threading.CancellationToken" /> to which to compare this instance.</param>
        public bool Equals(CancellationToken other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.Threading.CancellationToken" /> instance is equal to the specified <see cref="T:System.Object" />.</summary><returns>True if <paramref name="other" /> is a <see cref="T:System.Threading.CancellationToken" /> and if the two instances are equal; otherwise, false. Two tokens are equal if they are associated with the same <see cref="T:System.Threading.CancellationTokenSource" /> or if they were both constructed from public CancellationToken constructors and their <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> values are equal.</returns><param name="other">The other object to which to compare this instance.</param><exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
        public override bool Equals(object other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationToken" /> instances are equal.</summary><returns>True if the instances are equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param><exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationToken" /> instances are equal.</summary><returns>True if the instances are equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param><exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
        public static bool operator ==(CancellationToken left, CancellationToken right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationToken" /> instances are not equal.</summary><returns>True if the instances are not equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param><exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationToken" /> instances are not equal.</summary><returns>True if the instances are not equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param><exception cref="T:System.ObjectDisposedException">An associated <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
        public static bool operator !=(CancellationToken left, CancellationToken right)
        {
             throw new NotImplementedException();
        }
        
        
        public void ThrowIfCancellationRequested()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
