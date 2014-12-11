using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ManagementProbeAttribute : ManagementMemberAttribute
    {
    
        public Type Schema
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementProbeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
