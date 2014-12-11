using System.Threading;
using System;

namespace System.Threading.Tasks
{
    /// <summary>Provides support for creating and scheduling <see cref="T:System.Threading.Tasks.Task" /> objects.</summary>
    public class TaskFactory
    {
    
        /// <summary>Gets the default <see cref="T:System.Threading.CancellationToken" /> of this TaskFactory.</summary><returns>The default <see cref="T:System.Threading.CancellationToken" /> of this TaskFactory.</returns>
        public CancellationToken CancellationToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> of this TaskFactory.</summary><returns>The <see cref="T:System.Threading.Tasks.TaskScheduler" /> of this TaskFactory.</returns>
        public TaskScheduler Scheduler
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value of this TaskFactory.</summary><returns>The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value of this TaskFactory.</returns>
        public TaskCreationOptions CreationOptions
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value of this TaskFactory.</summary><returns>The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value of this TaskFactory.</returns>
        public TaskContinuationOptions ContinuationOptions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TaskFactory()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary><param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another CancellationToken is explicitly specified while calling the factory methods.</param>
        public TaskFactory(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary><param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to use to schedule any tasks created with this TaskFactory. A null value indicates that the current TaskScheduler should be used.</param>
        public TaskFactory(TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary><param name="creationOptions">The default <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> to use when creating tasks with this TaskFactory.</param><param name="continuationOptions">The default <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> to use when creating continuation tasks with this TaskFactory.</param><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument or the <paramref name="continuationOptions" /> argument specifies an invalid value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
        public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary><param name="cancellationToken">The default <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another CancellationToken is explicitly specified while calling the factory methods.</param><param name="creationOptions">The default <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> to use when creating tasks with this TaskFactory.</param><param name="continuationOptions">The default <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> to use when creating continuation tasks with this TaskFactory.</param><param name="scheduler">The default <see cref="T:System.Threading.Tasks.TaskScheduler" /> to use to schedule any Tasks created with this TaskFactory. A null value indicates that TaskScheduler.Current should be used.</param><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument or the <paramref name="continuationOptions" /> argument specifies an invalid value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
        public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary><returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns><param name="action">The action delegate to execute asynchronously.</param><exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception>
        public Task StartNew(Action action)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary><returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns><param name="action">The action delegate to execute asynchronously.</param><param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param><exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception><exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception>
        public Task StartNew(Action action, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary><returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns><param name="action">The action delegate to execute asynchronously.</param><param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param><exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value.</exception>
        public Task StartNew(Action action, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary><returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns><param name="action">The action delegate to execute asynchronously.</param><param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new <see cref="T:System.Threading.Tasks.Task" /></param><param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param><param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task" />.</param><exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception><exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
        public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task StartNew(Action<object> action, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task StartNew(Action<object> action, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<TResult> function)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }


        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
