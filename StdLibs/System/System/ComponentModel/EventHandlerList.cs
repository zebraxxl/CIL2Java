using System;

namespace System.ComponentModel
{
    public sealed class EventHandlerList : IDisposable
    {
    
        public Delegate this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventHandlerList()
        {
             throw new NotImplementedException();
        }
        
        
        public void AddHandler(object key, Delegate value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddHandlers(EventHandlerList listToAddFrom)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveHandler(object key, Delegate value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
