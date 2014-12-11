
namespace System.Configuration
{
    public sealed class SettingElementCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override string ElementName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override ConfigurationElement CreateNewElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override object GetElementKey(ConfigurationElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingElement Get(string elementKey)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(SettingElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(SettingElement element)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public SettingElementCollection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
