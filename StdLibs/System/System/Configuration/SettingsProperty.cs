using System;

namespace System.Configuration
{
    public class SettingsProperty
    {
    
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual object DefaultValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual Type PropertyType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual SettingsSerializeAs SerializeAs
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual SettingsProvider Provider
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual SettingsAttributeDictionary Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool ThrowOnErrorDeserializing
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool ThrowOnErrorSerializing
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SettingsProperty(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingsProperty(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingsProperty(SettingsProperty propertyToCopy)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
