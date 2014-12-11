using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class SettingsGroupDescriptionAttribute : Attribute
    {
    
        public string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsGroupDescriptionAttribute(string description)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
