using System;

namespace System.ComponentModel
{
    public class NestedContainer : Container, INestedContainer
    {
    
        public IComponent Owner
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual string OwnerName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NestedContainer(IComponent owner)
        {
             throw new NotImplementedException();
        }
        
        
        protected override ISite CreateSite(IComponent component, string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected override object GetService(Type service)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
