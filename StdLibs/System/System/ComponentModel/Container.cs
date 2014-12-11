using System;

namespace System.ComponentModel
{
    public class Container : IContainer
    {
    
        public virtual ComponentCollection Components
        {
            get { throw new NotImplementedException(); }
        }
    
    
        ~Container()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(IComponent component)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(IComponent component, string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual ISite CreateSite(IComponent component, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual object GetService(Type service)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Remove(IComponent component)
        {
             throw new NotImplementedException();
        }
        
        
        protected void RemoveWithoutUnsiting(IComponent component)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void ValidateName(IComponent component, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public Container()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
