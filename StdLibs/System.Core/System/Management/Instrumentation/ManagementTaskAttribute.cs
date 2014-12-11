using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ManagementTaskAttribute : ManagementMemberAttribute
    {
    
        public Type Schema
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementTaskAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
