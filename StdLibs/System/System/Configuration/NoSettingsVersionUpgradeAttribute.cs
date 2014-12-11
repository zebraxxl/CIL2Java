using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class NoSettingsVersionUpgradeAttribute : Attribute
    {
        public NoSettingsVersionUpgradeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
