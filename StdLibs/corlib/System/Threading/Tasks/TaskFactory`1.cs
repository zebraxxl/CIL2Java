using System.Runtime.CompilerServices;
using System.Threading;
using System;

namespace System.Threading.Tasks
{
    /// <summary>Provides support for creating and scheduling <see cref="T:System.Threading.Tasks.Task`1" /> objects.</summary><typeparam name="TResult">The type of the results that are available through the <see cref="T:System.Threading.Tasks.Task`1" /> objects that are associated with the methods in this class.</typeparam>
    public class TaskFactory<TResult>
    {
    
        /// <summary>Gets the default <see cref="T:System.Threading.CancellationToken" /> of this TaskFactory.</summary><returns>Returns the default <see cref="T:System.Threading.CancellationToken" /> of this TaskFactory.</returns>
        public CancellationToken CancellationToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> of this TaskFactory{TResult}.</summary><returns>Returns the <see cref="T:System.Threading.Tasks.TaskScheduler" /> of this <see cref="T:System.Threading.Tasks.TaskFactory" />.</returns>
        public TaskScheduler Scheduler
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value of this TaskFactory{TResult}.</summary><returns>Returns the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value of this <see cref="T:System.Threading.Tasks.TaskFactory" />.</returns>
        public TaskCreationOptions CreationOptions
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value of this TaskFactory{TResult}.</summary><returns>Returns the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value of this <see cref="T:System.Threading.Tasks.TaskFactory" />.</returns>
        public TaskContinuationOptions ContinuationOptions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TaskFactory()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the default configuration.</summary><param name="cancellationToken">The default cancellation token that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another cancellation token is explicitly specified when calling the factory methods.</param>
        public TaskFactory(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary><param name="scheduler">The scheduler to use to schedule any tasks created with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />. A null value indicates that the current <see cref="T:System.Threading.Tasks.TaskScheduler" /> should be used.</param>
        public TaskFactory(TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary><param name="creationOptions">The default options to use when creating tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param><param name="continuationOptions">The default options to use when creating continuation tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="creationOptions" /> or <paramref name="continuationOptions" /> specifies an invalid value.</exception>
        public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary><param name="cancellationToken">The default cancellation token that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another cancellation token is explicitly specified when calling the factory methods.</param><param name="creationOptions">The default options to use when creating tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param><param name="continuationOptions">The default options to use when creating continuation tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param><param name="scheduler">The default scheduler to use to schedule any tasks created with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />. A null value indicates that <see cref="P:System.Threading.Tasks.TaskScheduler.Current" /> should be used.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="creationOptions" /> or <paramref name="continuationOptions" /> specifies an invalid value.</exception>
        public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<TResult> function)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<object, TResult> function, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
