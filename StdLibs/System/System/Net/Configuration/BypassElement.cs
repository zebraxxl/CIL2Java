using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class BypassElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("address", IsRequired = true, IsKey = true)]
        public string Address
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public BypassElement()
        {
             throw new NotImplementedException();
        }
        
        
        public BypassElement(string address)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
