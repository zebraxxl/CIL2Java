using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class HttpWebRequestElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("maximumUnauthorizedUploadLength", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public int MaximumUnauthorizedUploadLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("maximumErrorResponseLength", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public int MaximumErrorResponseLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("maximumResponseHeadersLength", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public int MaximumResponseHeadersLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("useUnsafeHeaderParsing", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool UseUnsafeHeaderParsing
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HttpWebRequestElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
