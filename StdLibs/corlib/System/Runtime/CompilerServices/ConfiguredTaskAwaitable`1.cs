using System;
using System.Security;

namespace System.Runtime.CompilerServices
{
    /// <summary>Provides an awaitable object that allows for configured awaits on <see cref="T:System.Threading.Tasks.Task`1" />.</summary><typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
    public struct ConfiguredTaskAwaitable<TResult>
    {
        public struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
        {
        
            public bool IsCompleted
            {
                get { throw new NotImplementedException(); }
            }
        
        
            [SecuritySafeCriticalAttribute()]
            public void OnCompleted(Action continuation)
            {
                 throw new NotImplementedException();
            }
            
            
            [SecurityCriticalAttribute()]
            public void UnsafeOnCompleted(Action continuation)
            {
                 throw new NotImplementedException();
            }
            
            
            public TResult GetResult()
            {
                 throw new NotImplementedException();
            }
            
            
        }
    
    
        public ConfiguredTaskAwaiter GetAwaiter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
