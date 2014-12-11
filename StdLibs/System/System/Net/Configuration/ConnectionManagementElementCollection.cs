using System.Configuration;

namespace System.Net.Configuration
{
    [ConfigurationCollectionAttribute(typeof(ConnectionManagementElement))]
    public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
    {
        public ConnectionManagementElement this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public new ConnectionManagementElement this[string name]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ConnectionManagementElementCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(ConnectionManagementElement element)
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
        
        
        public int IndexOf(ConnectionManagementElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(ConnectionManagementElement element)
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
