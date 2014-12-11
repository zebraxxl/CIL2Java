using System;
using System.Collections;

namespace System.Collections.Specialized
{
    public class NotifyCollectionChangedEventArgs : EventArgs
    {
    
        public NotifyCollectionChangedAction Action
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList NewItems
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList OldItems
        {
            get { throw new NotImplementedException(); }
        }
    
        public int NewStartingIndex
        {
            get { throw new NotImplementedException(); }
        }
    
        public int OldStartingIndex
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
