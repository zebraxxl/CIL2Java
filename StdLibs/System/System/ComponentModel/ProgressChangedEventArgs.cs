using System;

namespace System.ComponentModel
{
    public class ProgressChangedEventArgs : EventArgs
    {
        internal ProgressChangedEventArgs()
        {
            //TODO: REMOVE THIS
        }
    
        public int ProgressPercentage
        {
            get { throw new NotImplementedException(); }
        }
    
        public object UserState
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ProgressChangedEventArgs(int progressPercentage, object userState)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
