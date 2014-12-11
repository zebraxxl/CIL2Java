using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = false)]
    public abstract class ManagementNewInstanceAttribute : ManagementMemberAttribute
    {
        protected ManagementNewInstanceAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
