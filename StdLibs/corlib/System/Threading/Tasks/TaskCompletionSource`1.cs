using System;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
    /// <summary>Represents the producer side of a <see cref="T:System.Threading.Tasks.Task`1" /> unbound to a delegate, providing access to the consumer side through the <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> property.</summary><typeparam name="TResult">The type of the result value assocatied with this <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</typeparam>
    public class TaskCompletionSource<TResult>
    {
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.Task`1" /> created by this <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</summary><returns>Returns the <see cref="T:System.Threading.Tasks.Task`1" /> created by this <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</returns>
        public Task<TResult> Task
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TaskCompletionSource()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> with the specified options.</summary><param name="creationOptions">The options to use when creating the underlying <see cref="T:System.Threading.Tasks.Task`1" />.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> represent options invalid for use with a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</exception>
        public TaskCompletionSource(TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> with the specified state.</summary><param name="state">The state to use as the underlying <see cref="T:System.Threading.Tasks.Task`1" />'s AsyncState.</param>
        public TaskCompletionSource(object state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" /> with the specified state and options.</summary><param name="state">The state to use as the underlying <see cref="T:System.Threading.Tasks.Task`1" />'s AsyncState.</param><param name="creationOptions">The options to use when creating the underlying <see cref="T:System.Threading.Tasks.Task`1" />.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> represent options invalid for use with a <see cref="T:System.Threading.Tasks.TaskCompletionSource`1" />.</exception>
        public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts to transition the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state.</summary><returns>True if the operation was successful; otherwise, false.</returns><param name="exception">The exception to bind to this <see cref="T:System.Threading.Tasks.Task`1" />.</param><exception cref="T:System.ObjectDisposedException">The <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> was disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="exception" /> argument is null.</exception>
        public bool TrySetException(Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TrySetException(IEnumerable<Exception> exceptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Transitions the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state.</summary><param name="exception">The exception to bind to this <see cref="T:System.Threading.Tasks.Task`1" />.</param><exception cref="T:System.ObjectDisposedException">The <see cref="P:System.Threading.Tasks.TaskCompletionSource`1.Task" /> was disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="exception" /> argument is null.</exception><exception cref="T:System.InvalidOperationException">The underlying <see cref="T:System.Threading.Tasks.Task`1" /> is already in one of the three final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
        public void SetException(Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetException(IEnumerable<Exception> exceptions)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TrySetResult(TResult result)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetResult(TResult result)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TrySetCanceled()
        {
             throw new NotImplementedException();
        }
        
        
        public void SetCanceled()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
