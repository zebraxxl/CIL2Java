using System;

namespace System.ComponentModel
{
    public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
    {
    
        public object Result
        {
            get { throw new NotImplementedException(); }
        }
    
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [BrowsableAttribute(false)]
        public new object UserState
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
