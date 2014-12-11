using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class DefaultSettingValueAttribute : Attribute
    {
    
        public string Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DefaultSettingValueAttribute(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
