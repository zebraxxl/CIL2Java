using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Property)]
    public sealed class SettingsProviderAttribute : Attribute
    {
    
        public string ProviderTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsProviderAttribute(string providerTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingsProviderAttribute(Type providerType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
