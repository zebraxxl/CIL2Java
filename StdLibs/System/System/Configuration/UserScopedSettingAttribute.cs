using System;

namespace System.Configuration
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class UserScopedSettingAttribute : SettingAttribute
    {
        public UserScopedSettingAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
