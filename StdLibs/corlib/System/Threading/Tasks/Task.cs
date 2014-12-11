using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
    /// <summary>Represents an asynchronous operation.</summary>
    [DebuggerDisplayAttribute("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
    public class Task : IAsyncResult, IDisposable
    {
    
        /// <summary>Gets a unique ID for this <see cref="T:System.Threading.Tasks.Task" /> instance.</summary><returns>An integer that was assigned by the system to this task instance.</returns>
        public int Id
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns the unique ID of the currently executing <see cref="T:System.Threading.Tasks.Task" />.</summary><returns>An integer that was assigned by the system to the currently-executing task.</returns>
        public static Nullable<int> CurrentId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely. If the <see cref="T:System.Threading.Tasks.Task" /> completed successfully or has not yet thrown any exceptions, this will return null.</summary><returns>The <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely.</returns>
        public AggregateException Exception
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskStatus" /> of this Task.</summary><returns>The current <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task instance.</returns>
        public TaskStatus Status
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> instance has completed execution due to being canceled.</summary><returns>true if the task has completed due to being canceled; otherwise false.</returns>
        public bool IsCanceled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> has completed.</summary><returns>true if the task has completed; otherwise false.</returns>
        public bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</summary><returns>The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</returns>
        public TaskCreationOptions CreationOptions
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the state object supplied when the <see cref="T:System.Threading.Tasks.Task" /> was created, or null if none was supplied.</summary><returns>An <see cref="T:System.Object" /> that represents the state data that was passed in to the task when it was created.</returns>
        public object AsyncState
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Provides access to factory methods for creating <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary><returns>The default <see cref="T:System.Threading.Tasks.TaskFactory" /> for the current task.</returns>
        public static TaskFactory Factory
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether the <see cref="T:System.Threading.Tasks.Task" /> completed due to an unhandled exception.</summary><returns>true if the task has thrown an unhandled exception; otherwise false.</returns>
        public bool IsFaulted
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action.</summary><param name="action">The delegate that represents the code to execute in the Task.</param><exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
        public Task(Action action)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and <see cref="T:System.Threading.CancellationToken" />.</summary><param name="action">The delegate that represents the code to execute in the Task.</param><param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that the new Task will observe.</param><exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
        public Task(Action action, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and creation options.</summary><param name="action">The delegate that represents the code to execute in the task.</param><param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the Task's behavior. </param><exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
        public Task(Action action, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and creation options.</summary><param name="action">The delegate that represents the code to execute in the task.</param><param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that the new task will observe.</param><param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the Task's behavior.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
        public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Action<object> action, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Action<object> action, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Action<object> action, object state, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public void Start()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the specified <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary><param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> with which to associate and execute this task.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
        public void Start(TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public void RunSynchronously()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Runs the <see cref="T:System.Threading.Tasks.Task" /> synchronously on the <see cref="T:System.Threading.Tasks.TaskScheduler" /> provided.</summary><param name="scheduler">The scheduler on which to attempt to run this task inline.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> parameter is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
        public void RunSynchronously(TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Disposes the <see cref="T:System.Threading.Tasks.Task" />, releasing all of its unmanaged resources.</summary><param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.Tasks.Task.Dispose" />.</param><exception cref="T:System.InvalidOperationException">The exception that is thrown if the <see cref="T:System.Threading.Tasks.Task" /> is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public TaskAwaiter GetAwaiter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary><returns>An object used to await this task.</returns><param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
        public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
        {
             throw new NotImplementedException();
        }
        
        
        public static YieldAwaitable Yield()
        {
             throw new NotImplementedException();
        }
        
        
        public void Wait()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary><returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.AggregateException">The <see cref="T:System.Threading.Tasks.Task" /> was canceled -or- an exception was thrown during the execution of the <see cref="T:System.Threading.Tasks.Task" />.</exception>
        public bool Wait(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary><param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the task to complete.</param><exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.AggregateException">The <see cref="T:System.Threading.Tasks.Task" /> was canceled -or- an exception was thrown during the execution of the <see cref="T:System.Threading.Tasks.Task" />. If the task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
        public void Wait(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary><returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.AggregateException">The <see cref="T:System.Threading.Tasks.Task" /> was canceled -or- an exception was thrown during the execution of the <see cref="T:System.Threading.Tasks.Task" />. If the task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
        public bool Wait(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary><returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the task to complete.</param><exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.AggregateException">The <see cref="T:System.Threading.Tasks.Task" /> was canceled -or- an exception was thrown during the execution of the <see cref="T:System.Threading.Tasks.Task" />. If the task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task> continuationAction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task, object> continuationAction, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.-or-The <paramref name="tasks" /> argument contains a null element.</exception><exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
        public static void WaitAll(params  Task[] tasks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
        public static bool WaitAll(Task[] tasks, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
        public static bool WaitAll(Task[] tasks, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param><exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception><exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
        public static void WaitAll(Task[] tasks, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param><exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception><exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
        public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
        public static int WaitAny(params  Task[] tasks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
        public static int WaitAny(Task[] tasks, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception><exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
        public static int WaitAny(Task[] tasks, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
        public static int WaitAny(Task[] tasks, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary><returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns><param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param><param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param><param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete.</param><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception><exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
        public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult> FromResult<TResult>(TResult result)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Queues the specified work to run on the ThreadPool and returns a Task handle for that work.</summary><returns>A Task that represents the work queued to execute in the ThreadPool.</returns><param name="action">The work to execute asynchronously</param><exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
        public static Task Run(Action action)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Queues the specified work to run on the ThreadPool and returns a Task handle for that work.</summary><returns>A Task that represents the work queued to execute in the ThreadPool.</returns><param name="action">The work to execute asynchronously</param><param name="cancellationToken">A cancellation token that should be used to cancel the work</param><exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was null.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
        public static Task Run(Action action, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult> Run<TResult>(Func<TResult> function)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task Run(Func<Task> function)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task Run(Func<Task> function, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a Task that will complete after a time delay.</summary><returns>A Task that represents the time delay</returns><param name="delay">The time span to wait before completing the returned Task</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="delay" /> is less than -1 or greater than Int32.MaxValue.</exception>
        public static Task Delay(TimeSpan delay)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a Task that will complete after a time delay.</summary><returns>A Task that represents the time delay</returns><param name="delay">The time span to wait before completing the returned Task</param><param name="cancellationToken">The cancellation token that will be checked prior to completing the returned Task</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="delay" /> is less than -1 or greater than Int32.MaxValue.</exception><exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed.</exception>
        public static Task Delay(TimeSpan delay, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a Task that will complete after a time delay.</summary><returns>A Task that represents the time delay</returns><param name="millisecondsDelay">The number of milliseconds to wait before completing the returned Task</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> is less than -1.</exception>
        public static Task Delay(int millisecondsDelay)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a Task that will complete after a time delay.</summary><returns>A Task that represents the time delay</returns><param name="millisecondsDelay">The number of milliseconds to wait before completing the returned Task</param><param name="cancellationToken">The cancellation token that will be checked prior to completing the returned Task</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> is less than -1.</exception><exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed.</exception>
        public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task WhenAll(IEnumerable<Task> tasks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a task that will complete when all of the supplied tasks have completed.</summary><returns>A task that represents the completion of all of the supplied tasks.</returns><param name="tasks">The tasks to wait on for completion.</param><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
        public static Task WhenAll(params  Task[] tasks)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<TResult[]> WhenAll<TResult>(params  Task<TResult>[] tasks)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary><returns>A task that represents the completion of one of the supplied tasks.  The return Task's Result is the task that completed.</returns><param name="tasks">The tasks to wait on for completion.</param><exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception><exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
        public static Task<Task> WhenAny(params  Task[] tasks)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<Task> WhenAny(IEnumerable<Task> tasks)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<Task<TResult>> WhenAny<TResult>(params  Task<TResult>[] tasks)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks)
        {
             throw new NotImplementedException();
        }



        bool IAsyncResult.IsCompleted
        {
            get { throw new NotImplementedException(); }
        }

        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get { throw new NotImplementedException(); }
        }

        object IAsyncResult.AsyncState
        {
            get { throw new NotImplementedException(); }
        }

        bool IAsyncResult.CompletedSynchronously
        {
            get { throw new NotImplementedException(); }
        }
    }
}
