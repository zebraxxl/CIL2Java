
namespace System.Configuration
{
    [ConfigurationCollectionAttribute(typeof(SchemeSettingElement), CollectionType = ConfigurationElementCollectionType.BasicMap, AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
    public sealed class SchemeSettingElementCollection : ConfigurationElementCollection
    {
    
        public override ConfigurationElementCollectionType CollectionType
        {
            get { throw new NotImplementedException(); }
        }
    
        public SchemeSettingElement this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public new SchemeSettingElement this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SchemeSettingElementCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(SchemeSettingElement element)
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
        
        
    }
}
