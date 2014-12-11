using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public abstract class ManagementMemberAttribute : Attribute
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected ManagementMemberAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
