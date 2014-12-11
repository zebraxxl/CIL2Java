using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public abstract class EventDescriptor : MemberDescriptor
    {
        public abstract Type ComponentType
        {
            get;
        }
    
        public abstract Type EventType
        {
            get;
        }
    
        public abstract bool IsMulticast
        {
            get;
        }
    
    
        protected EventDescriptor(string name, Attribute[] attrs)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventDescriptor(MemberDescriptor descr)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void AddEventHandler(object component, Delegate value);
        
        
        public abstract void RemoveEventHandler(object component, Delegate value);
        
        
    }
}
