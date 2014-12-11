using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class ManagementReferenceAttribute : Attribute
    {
    
        public string Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementReferenceAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
