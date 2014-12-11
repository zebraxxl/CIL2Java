using System;

namespace System.IO
{
    public class ErrorEventArgs : EventArgs
    {
    
        public ErrorEventArgs(Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Exception GetException()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
