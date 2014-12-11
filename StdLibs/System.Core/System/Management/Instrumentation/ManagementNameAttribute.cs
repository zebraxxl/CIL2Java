using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class ManagementNameAttribute : Attribute
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ManagementNameAttribute(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
