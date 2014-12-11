using System;

namespace System.Management.Instrumentation
{
    [AttributeUsageAttribute(AttributeTargets.Assembly)]
    public sealed class WmiConfigurationAttribute : Attribute
    {
    
        public string SecurityRestriction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string NamespaceSecurity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IdentifyLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ManagementHostingModel HostingModel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string HostingGroup
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Scope
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WmiConfigurationAttribute(string scope)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
