using System;

namespace System.ComponentModel
{
    public class RefreshEventArgs : EventArgs
    {
    
        public object ComponentChanged
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type TypeChanged
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RefreshEventArgs(object componentChanged)
        {
             throw new NotImplementedException();
        }
        
        
        public RefreshEventArgs(Type typeChanged)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
