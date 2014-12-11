using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class AuthenticationModuleElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("type", IsRequired = true, IsKey = true)]
        public string Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AuthenticationModuleElement()
        {
             throw new NotImplementedException();
        }
        
        
        public AuthenticationModuleElement(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
