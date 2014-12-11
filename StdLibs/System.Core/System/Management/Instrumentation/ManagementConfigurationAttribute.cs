using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ManagementConfigurationAttribute : ManagementMemberAttribute
    {
    
        public ManagementConfigurationType Mode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Type Schema
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementConfigurationAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
