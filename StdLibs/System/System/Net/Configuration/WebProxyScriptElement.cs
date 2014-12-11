using System.Configuration;
using System;

namespace System.Net.Configuration
{
    public sealed class WebProxyScriptElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("downloadTimeout", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public TimeSpan DownloadTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebProxyScriptElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
