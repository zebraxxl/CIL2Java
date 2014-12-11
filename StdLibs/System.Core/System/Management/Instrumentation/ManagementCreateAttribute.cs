using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ManagementCreateAttribute : ManagementNewInstanceAttribute
    {
        public ManagementCreateAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
