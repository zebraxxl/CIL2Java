using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
    /// <summary>Represents a builder for asynchronous methods that return a task.</summary>
    public struct AsyncTaskMethodBuilder
    {
    
        /// <summary>Gets the task for this builder.</summary><returns>The task for this builder.</returns><exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
        public Task Task
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static AsyncTaskMethodBuilder Create()
        {
             throw new NotImplementedException();
        }
        
        
        [DebuggerStepThroughAttribute()]
        public void Start<TStateMachine>(ref TStateMachine stateMachine)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Associates the builder with the specified state machine.</summary><param name="stateMachine">The state machine instance to associate with the builder.</param><exception cref="T:System.ArgumentNullException"><paramref name="stateMachine" /> is null.</exception><exception cref="T:System.InvalidOperationException">The state machine was previously set.</exception>
        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
             throw new NotImplementedException();
        }
        
        
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        {
             throw new NotImplementedException();
        }
        
        
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetResult()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marks the task as failed and binds the specified exception to the task.</summary><param name="exception">The exception to bind to the task.</param><exception cref="T:System.ArgumentNullException"><paramref name="exception" /> is null.</exception><exception cref="T:System.InvalidOperationException">The task has already completed.-or-The builder is not initialized.</exception>
        public void SetException(Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
