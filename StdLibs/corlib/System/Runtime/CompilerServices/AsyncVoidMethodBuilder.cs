using System;
using System.Diagnostics;
using System.Security;

namespace System.Runtime.CompilerServices
{
    /// <summary>Represents a builder for asynchronous methods that do not return a value.</summary>
    public struct AsyncVoidMethodBuilder
    {
    
    
        public static AsyncVoidMethodBuilder Create()
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
        
        
        [SecuritySafeCriticalAttribute()]
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetResult()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Binds an exception to the method builder.</summary><param name="exception">The exception to bind.</param><exception cref="T:System.ArgumentNullException"><paramref name="exception" /> is null.</exception><exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
        public void SetException(Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
