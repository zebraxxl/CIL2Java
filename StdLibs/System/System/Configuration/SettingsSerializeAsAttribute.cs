using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Property)]
    public sealed class SettingsSerializeAsAttribute : Attribute
    {
    
        public SettingsSerializeAs SerializeAs
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
