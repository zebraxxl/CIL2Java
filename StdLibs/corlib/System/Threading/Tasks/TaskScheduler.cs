using System.Diagnostics;
using System;
using System.Security;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
    /// <summary>Represents an object that handles the low-level work of queuing tasks onto threads.</summary>
    [DebuggerDisplayAttribute("Id={Id}")]
    public abstract class TaskScheduler
    {
    
        /// <summary>Occurs when a faulted <see cref="T:System.Threading.Tasks.Task" />'s unobserved exception is about to trigger exception escalation policy, which, by default, would terminate the process.</summary>
        public static event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException;
    
    
        /// <summary>Indicates the maximum concurrency level this <see cref="T:System.Threading.Tasks.TaskScheduler" /> is able to support.</summary><returns>Returns an integer that represents the maximum concurrency level. The default scheduler returns <see cref="F:System.Int32.MaxValue" />.</returns>
        public virtual int MaximumConcurrencyLevel
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance that is provided by the .NET Framework.</summary><returns>Returns the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance.</returns>
        public static TaskScheduler Default
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</summary><returns>Returns the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</returns>
        public static TaskScheduler Current
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary><returns>Returns the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</returns>
        public int Id
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Queues a <see cref="T:System.Threading.Tasks.Task" /> to the scheduler.</summary><param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be queued.</param><exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
        [SecurityCriticalAttribute()]
        protected abstract void QueueTask(Task task);
        
        
        /// <summary>Determines whether the provided <see cref="T:System.Threading.Tasks.Task" /> can be executed synchronously in this call, and if it can, executes it.</summary><returns>A Boolean value indicating whether the task was executed inline.</returns><param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be executed.</param><param name="taskWasPreviouslyQueued">A Boolean denoting whether or not task has previously been queued. If this parameter is True, then the task may have been previously queued (scheduled); if False, then the task is known not to have been queued, and this call is being made in order to execute the task inline without queuing it.</param><exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception><exception cref="T:System.InvalidOperationException">The <paramref name="task" /> was already executed.</exception>
        [SecurityCriticalAttribute()]
        protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);
        
        
        [SecurityCriticalAttribute()]
        protected abstract IEnumerable<Task> GetScheduledTasks();
        
        
        /// <summary>Attempts to dequeue a <see cref="T:System.Threading.Tasks.Task" /> that was previously queued to this scheduler.</summary><returns>A Boolean denoting whether the <paramref name="task" /> argument was successfully dequeued.</returns><param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be dequeued.</param><exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
        [SecurityCriticalAttribute()]
        protected virtual bool TryDequeue(Task task)
        {
             throw new NotImplementedException();
        }
        
        
        protected TaskScheduler()
        {
             throw new NotImplementedException();
        }
        
        
        public static TaskScheduler FromCurrentSynchronizationContext()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts to execute the provided <see cref="T:System.Threading.Tasks.Task" /> on this scheduler.</summary><returns>A Boolean that is true if <paramref name="task" /> was successfully executed, false if it was not. A common reason for execution failure is that the task had previously been executed or is in the process of being executed by another thread.</returns><param name="task">A <see cref="T:System.Threading.Tasks.Task" /> object to be executed.</param><exception cref="T:System.InvalidOperationException">The <paramref name="task" /> is not associated with this scheduler.</exception>
        [SecurityCriticalAttribute()]
        protected bool TryExecuteTask(Task task)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
