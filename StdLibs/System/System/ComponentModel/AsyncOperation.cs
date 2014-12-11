using System.Threading;

namespace System.ComponentModel
{
    public sealed class AsyncOperation
    {
    
        public object UserSuppliedState
        {
            get { throw new NotImplementedException(); }
        }
    
        public SynchronizationContext SynchronizationContext
        {
            get { throw new NotImplementedException(); }
        }
    
    
        ~AsyncOperation()
        {
             throw new NotImplementedException();
        }
        
        
        public void Post(SendOrPostCallback d, object arg)
        {
             throw new NotImplementedException();
        }
        
        
        public void PostOperationCompleted(SendOrPostCallback d, object arg)
        {
             throw new NotImplementedException();
        }
        
        
        public void OperationCompleted()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
