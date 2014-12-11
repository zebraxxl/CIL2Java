using System;

namespace Microsoft.Win32
{
    public class SessionEndingEventArgs : EventArgs
    {
    
        public bool Cancel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SessionEndReasons Reason
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SessionEndingEventArgs(SessionEndReasons reason)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
