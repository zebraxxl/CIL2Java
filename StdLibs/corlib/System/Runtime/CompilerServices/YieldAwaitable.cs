using System;
using System.Security;

namespace System.Runtime.CompilerServices
{
    /// <summary>Provides the context for waiting when asynchronously switching into a target environment.</summary>
    public struct YieldAwaitable
    {
        public struct YieldAwaiter : ICriticalNotifyCompletion
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
            
            
            public void GetResult()
            {
                 throw new NotImplementedException();
            }
            
            
        }
    
        public YieldAwaiter GetAwaiter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
