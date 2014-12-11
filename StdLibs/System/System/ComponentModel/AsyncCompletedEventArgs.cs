using System;

namespace System.ComponentModel
{
    public class AsyncCompletedEventArgs : EventArgs
    {
    
        public bool Cancelled
        {
            get { throw new NotImplementedException(); }
        }
    
        public Exception Error
        {
            get { throw new NotImplementedException(); }
        }
    
        public object UserState
        {
            get { throw new NotImplementedException(); }
        }
    
    
        //[ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public AsyncCompletedEventArgs()
        {
             throw new NotImplementedException();
        }
        
        
        public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
        {
             throw new NotImplementedException();
        }
        
        
        protected void RaiseExceptionIfNecessary()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
