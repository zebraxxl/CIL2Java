using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration
{
    public sealed class SmtpSection : ConfigurationSection
    {
    
        //[ConfigurationPropertyAttribute("deliveryMethod", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public SmtpDeliveryMethod DeliveryMethod
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("deliveryFormat", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public SmtpDeliveryFormat DeliveryFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("from")]
        public string From
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("network")]
        public SmtpNetworkElement Network
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("specifiedPickupDirectory")]
        public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SmtpSection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
