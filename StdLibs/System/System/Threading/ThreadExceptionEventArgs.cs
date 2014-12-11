using System;

namespace System.Threading
{
    public class ThreadExceptionEventArgs : EventArgs
    {
    
        public Exception Exception
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ThreadExceptionEventArgs(Exception t)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
