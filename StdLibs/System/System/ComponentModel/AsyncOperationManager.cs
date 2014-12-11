using System.Threading;

namespace System.ComponentModel
{
    public static class AsyncOperationManager
    {
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static SynchronizationContext SynchronizationContext
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public static AsyncOperation CreateOperation(object userSuppliedState)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
