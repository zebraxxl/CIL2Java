using System.Configuration;

namespace System.Net.Configuration
{
    [ConfigurationCollectionAttribute(typeof(WebRequestModuleElement))]
    public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
    {
        public WebRequestModuleElement this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public new WebRequestModuleElement this[string name]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public WebRequestModuleElementCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(WebRequestModuleElement element)
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
        
        
        public int IndexOf(WebRequestModuleElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(WebRequestModuleElement element)
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
