using System;

namespace System.ComponentModel
{
    public class ListChangedEventArgs : EventArgs
    {
    
        public ListChangedType ListChangedType
        {
            get { throw new NotImplementedException(); }
        }
    
        public int NewIndex
        {
            get { throw new NotImplementedException(); }
        }
    
        public int OldIndex
        {
            get { throw new NotImplementedException(); }
        }
    
        public PropertyDescriptor PropertyDescriptor
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
