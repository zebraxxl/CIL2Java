using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class WebUtilityElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("unicodeDecodingConformance", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public UnicodeDecodingConformance UnicodeDecodingConformance
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("unicodeEncodingConformance", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public UnicodeEncodingConformance UnicodeEncodingConformance
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebUtilityElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
