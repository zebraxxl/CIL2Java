using System;
using System.Security;

namespace System.Runtime.CompilerServices
{
    /// <summary>Represents an object that waits for the completion of an asynchronous task and provides a parameter for the result.</summary><typeparam name="TResult">The result for the task.</typeparam>
    public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion
    {
    
        /// <summary>Gets a value that indicates whether the asynchronous task has completed.</summary><returns>true if the task has completed; otherwise, false.</returns><exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> object was not properly initialized.</exception>
        public bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Sets the action to perform when the <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> object stops waiting for the asynchronous task to complete.</summary><param name="continuation">The action to perform when the wait operation completes.</param><exception cref="T:System.ArgumentNullException"><paramref name="continuation" /> is null.</exception><exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> object was not properly initialized.</exception>
        [SecuritySafeCriticalAttribute()]
        public void OnCompleted(Action continuation)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Schedules the continuation action for the asynchronous task associated with this awaiter.</summary><param name="continuation">The action to invoke when the await operation completes.</param><exception cref="T:System.ArgumentNullException"><paramref name="continuation" /> is null.</exception><exception cref="T:System.InvalidOperationException">The awaiter was not properly initialized.</exception>
        [SecurityCriticalAttribute()]
        public void UnsafeOnCompleted(Action continuation)
        {
             throw new NotImplementedException();
        }
        
        
        public TResult GetResult()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
