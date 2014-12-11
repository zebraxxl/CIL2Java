using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class SmtpNetworkElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("defaultCredentials", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool DefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("host")]
        public string Host
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("targetName")]
        public string TargetName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("clientDomain")]
        public string ClientDomain
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("password")]
        public string Password
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("port", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public int Port
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("userName")]
        public string UserName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("enableSsl", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool EnableSsl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SmtpNetworkElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
