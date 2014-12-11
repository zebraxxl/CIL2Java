using System.Configuration;
using System.Net.Security;

namespace System.Net.Configuration
{
    public sealed class ServicePointManagerElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("checkCertificateName", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool CheckCertificateName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("checkCertificateRevocationList", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool CheckCertificateRevocationList
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("dnsRefreshTimeout", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public int DnsRefreshTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("enableDnsRoundRobin", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool EnableDnsRoundRobin
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("encryptionPolicy", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public EncryptionPolicy EncryptionPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("expect100Continue", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool Expect100Continue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("useNagleAlgorithm", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool UseNagleAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ServicePointManagerElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
