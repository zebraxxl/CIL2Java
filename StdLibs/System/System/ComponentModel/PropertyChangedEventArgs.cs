using System;

namespace System.ComponentModel
{
    public class PropertyChangedEventArgs : EventArgs
    {
    
        public virtual string PropertyName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PropertyChangedEventArgs(string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
