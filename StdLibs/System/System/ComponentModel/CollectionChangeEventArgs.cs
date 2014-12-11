using System;

namespace System.ComponentModel
{
    public class CollectionChangeEventArgs : EventArgs
    {
    
        public virtual CollectionChangeAction Action
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual object Element
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CollectionChangeEventArgs(CollectionChangeAction action, object element)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
