using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class SettingsDescriptionAttribute : Attribute
    {
    
        public string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsDescriptionAttribute(string description)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
