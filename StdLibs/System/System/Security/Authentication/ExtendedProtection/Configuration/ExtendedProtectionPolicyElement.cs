using System.Configuration;
using System.Security.Authentication.ExtendedProtection;

namespace System.Security.Authentication.ExtendedProtection.Configuration
{
    public sealed class ExtendedProtectionPolicyElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("policyEnforcement")]
        public PolicyEnforcement PolicyEnforcement
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("protectionScenario", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public ProtectionScenario ProtectionScenario
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("customServiceNames")]
        public ServiceNameElementCollection CustomServiceNames
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ExtendedProtectionPolicyElement()
        {
             throw new NotImplementedException();
        }
        
        
        public ExtendedProtectionPolicy BuildPolicy()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
