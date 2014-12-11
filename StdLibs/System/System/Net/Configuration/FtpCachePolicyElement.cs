using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
    public sealed class FtpCachePolicyElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("policyLevel", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public RequestCacheLevel PolicyLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public FtpCachePolicyElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Reset(ConfigurationElement parentElement)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
