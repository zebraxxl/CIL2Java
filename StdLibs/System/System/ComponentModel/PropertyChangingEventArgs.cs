using System;

namespace System.ComponentModel
{
    public class PropertyChangingEventArgs : EventArgs
    {
    
        public virtual string PropertyName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PropertyChangingEventArgs(string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
