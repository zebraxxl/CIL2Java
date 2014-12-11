using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class DefaultProxySection : ConfigurationSection
    {
    
        [ConfigurationPropertyAttribute("bypasslist")]
        public BypassElementCollection BypassList
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("module")]
        public ModuleElement Module
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("proxy")]
        public ProxyElement Proxy
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("enabled", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("useDefaultCredentials", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public DefaultProxySection()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Reset(ConfigurationElement parentElement)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
