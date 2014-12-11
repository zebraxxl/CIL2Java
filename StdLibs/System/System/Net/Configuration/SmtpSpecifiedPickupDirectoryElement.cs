using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("pickupDirectoryLocation")]
        public string PickupDirectoryLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SmtpSpecifiedPickupDirectoryElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
