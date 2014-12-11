using System;

namespace System.ComponentModel.Design
{
    public class ServiceContainer : IServiceContainer, IDisposable
    {
    
        protected virtual Type[] DefaultServices
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ServiceContainer()
        {
             throw new NotImplementedException();
        }
        
        
        public ServiceContainer(IServiceProvider parentProvider)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddService(Type serviceType, object serviceInstance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AddService(Type serviceType, object serviceInstance, bool promote)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddService(Type serviceType, ServiceCreatorCallback callback)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
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
        
        
        public virtual object GetService(Type serviceType)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveService(Type serviceType)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RemoveService(Type serviceType, bool promote)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
