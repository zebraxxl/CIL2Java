using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class ManagementEntityAttribute : Attribute
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool External
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool Singleton
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ManagementEntityAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
