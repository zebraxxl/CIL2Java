using System.Configuration;

namespace System.Net.Configuration
{
    [ConfigurationCollectionAttribute(typeof(BypassElement))]
    public sealed class BypassElementCollection : ConfigurationElementCollection
    {
        public BypassElement this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public new BypassElement this[string name]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override bool ThrowOnDuplicate
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public BypassElementCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(BypassElement element)
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
        
        
        public int IndexOf(BypassElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(BypassElement element)
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
