using System.Configuration;

namespace System.Security.Authentication.ExtendedProtection.Configuration
{
    public sealed class ServiceNameElement : ConfigurationElement
    {
    
        [ConfigurationPropertyAttribute("name")]
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ServiceNameElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
