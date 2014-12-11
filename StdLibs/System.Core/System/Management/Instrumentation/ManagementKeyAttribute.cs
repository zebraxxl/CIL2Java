using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ManagementKeyAttribute : ManagementMemberAttribute
    {
        public ManagementKeyAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
