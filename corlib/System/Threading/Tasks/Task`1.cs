using System.Diagnostics;
using System.Runtime.CompilerServices;
using System;
using System.Threading;

namespace System.Threading.Tasks
{
    /// <summary>Represents an asynchronous operation that can return a value.</summary><typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />. </typeparam>
    [DebuggerDisplayAttribute("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
    public class Task<TResult> : Task
    {
    
        /// <summary>Gets the result value of this <see cref="T:System.Threading.Tasks.Task`1" />.</summary><returns>The result value of this <see cref="T:System.Threading.Tasks.Task`1" />, which is the same type as the task's type parameter.</returns>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        public TResult Result
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Provides access to factory methods for creating <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary><returns>A default instance of <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</returns>
        public static new TaskFactory<TResult> Factory
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Task(Func<TResult> function)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<TResult> function, CancellationToken cancellationToken)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<TResult> function, TaskCreationOptions creationOptions)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<object, TResult> function, object state)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
            : base(null)
        {
             throw new NotImplementedException();
        }


        public new TaskAwaiter<TResult> GetAwaiter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary><returns>An object used to await this task.</returns><param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
        public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>> continuationAction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
