using System.Configuration;

namespace System.Net.Configuration
{
    [ConfigurationCollectionAttribute(typeof(AuthenticationModuleElement))]
    public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection
    {
        public AuthenticationModuleElement this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public new AuthenticationModuleElement this[string name]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AuthenticationModuleElementCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(AuthenticationModuleElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        protected override ConfigurationElement CreateNewElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override object GetElementKey(ConfigurationElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(AuthenticationModuleElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(AuthenticationModuleElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
