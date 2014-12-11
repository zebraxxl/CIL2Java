using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Method)]
    public sealed class ManagementCommitAttribute : ManagementMemberAttribute
    {
        public ManagementCommitAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
