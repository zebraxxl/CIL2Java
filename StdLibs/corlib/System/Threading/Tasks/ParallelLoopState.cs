using System.Diagnostics;
using System;

namespace System.Threading.Tasks
{
    /// <summary>Enables iterations of <see cref="T:System.Threading.Tasks.Parallel" /> loops to interact with other iterations. An instance of this class is provided by the Parallel class to each loop; you can not create instances in your user code.</summary>
    [DebuggerDisplayAttribute("ShouldExitCurrentIteration = {ShouldExitCurrentIteration}")]
    public class ParallelLoopState
    {
    
        /// <summary>Gets whether the current iteration of the loop should exit based on requests made by this or other iterations.</summary><returns>true if the current iteration should exit; otherwise false.</returns>
        public bool ShouldExitCurrentIteration
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether any iteration of the loop has called <see cref="M:System.Threading.Tasks.ParallelLoopState.Stop" />.</summary><returns>true if any iteration has stopped the loop; otherwise false.</returns>
        public bool IsStopped
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether any iteration of the loop has thrown an exception that went unhandled by that iteration.</summary><returns>True if an unhandled exception was thrown; otherwise false.</returns>
        public bool IsExceptional
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the lowest iteration of the loop from which <see cref="M:System.Threading.Tasks.ParallelLoopState.Break" /> was called. </summary><returns>An integer that represents the lowest iteration from which Break was called. In the case of a <see cref="M:System.Threading.Tasks.Parallel.ForEach``1(System.Collections.Concurrent.Partitioner{``0},System.Action{``0})" /> loop, the value is based on an internally-generated index.</returns>
        public Nullable<long> LowestBreakIteration
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void Stop()
        {
             throw new NotImplementedException();
        }
        
        
        public void Break()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
