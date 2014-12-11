using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class SettingsGroupNameAttribute : Attribute
    {
    
        public string GroupName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsGroupNameAttribute(string groupName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
