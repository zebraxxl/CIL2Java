using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class ApplicationScopedSettingAttribute : SettingAttribute
    {
        public ApplicationScopedSettingAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
