using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Property)]
    public sealed class SettingsManageabilityAttribute : Attribute
    {
    
        public SettingsManageability Manageability
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsManageabilityAttribute(SettingsManageability manageability)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
