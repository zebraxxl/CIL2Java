using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
    /// <summary>Provides task schedulers that coordinate to execute tasks while ensuring that concurrent tasks may run concurrently and exclusive tasks never do.</summary>
    [DebuggerDisplayAttribute("Concurrent={ConcurrentTaskCountForDebugger}, Exclusive={ExclusiveTaskCountForDebugger}, Mode={ModeForDebugger}")]
    public class ConcurrentExclusiveSchedulerPair
    {
    
        /// <summary>Gets a <see cref="T:System.Threading.Tasks.Task" /> that will complete when the scheduler has completed processing.</summary><returns>The asynchronous operation that will complete when the scheduler finishes processing.</returns>
        public Task Completion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Threading.Tasks.TaskScheduler" /> that can be used to schedule tasks to this pair that may run concurrently with other tasks on this pair.</summary><returns>An object that can be used to schedule tasks concurrently.</returns>
        public TaskScheduler ConcurrentScheduler
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Threading.Tasks.TaskScheduler" /> that can be used to schedule tasks to this pair that must run exclusively with regards to other tasks on this pair.</summary><returns>An object that can be used to schedule tasks that do not run concurrently with other tasks.</returns>
        public TaskScheduler ExclusiveScheduler
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ConcurrentExclusiveSchedulerPair()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.ConcurrentExclusiveSchedulerPair" /> class that targets the specified scheduler.</summary><param name="taskScheduler">The target scheduler on which this pair should execute.</param>
        public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.ConcurrentExclusiveSchedulerPair" /> class that targets the specified scheduler with a maximum concurrency level.</summary><param name="taskScheduler">The target scheduler on which this pair should execute.</param><param name="maxConcurrencyLevel">The maximum number of tasks to run concurrently.</param>
        public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.ConcurrentExclusiveSchedulerPair" /> class that targets the specified scheduler with a maximum concurrency level and a maximum number of scheduled tasks that may be processed as a unit.</summary><param name="taskScheduler">The target scheduler on which this pair should execute.</param><param name="maxConcurrencyLevel">The maximum number of tasks to run concurrently.</param><param name="maxItemsPerTask">The maximum number of tasks to process for each underlying scheduled task used by the pair.</param>
        public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel, int maxItemsPerTask)
        {
             throw new NotImplementedException();
        }
        
        
        public void Complete()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
