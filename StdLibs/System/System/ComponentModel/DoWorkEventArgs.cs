using System;

namespace System.ComponentModel
{
    public class DoWorkEventArgs : CancelEventArgs
    {
    
        public object Argument
        {
            get { throw new NotImplementedException(); }
        }
    
        public object Result
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public DoWorkEventArgs(object argument)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
