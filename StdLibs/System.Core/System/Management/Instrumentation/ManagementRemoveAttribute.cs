using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ManagementRemoveAttribute : ManagementMemberAttribute
    {
    
        public Type Schema
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementRemoveAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
