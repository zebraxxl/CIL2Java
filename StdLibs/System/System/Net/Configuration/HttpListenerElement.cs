using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class HttpListenerElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("unescapeRequestUrl", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public bool UnescapeRequestUrl
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("timeouts")]
        public HttpListenerTimeoutsElement Timeouts
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HttpListenerElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
