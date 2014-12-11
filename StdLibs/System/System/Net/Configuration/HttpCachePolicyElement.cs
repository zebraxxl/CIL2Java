using System.Configuration;
using System;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
    public sealed class HttpCachePolicyElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("maximumAge", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public TimeSpan MaximumAge
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("maximumStale", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public TimeSpan MaximumStale
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("minimumFresh", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public TimeSpan MinimumFresh
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("policyLevel", IsRequired = true, DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public HttpRequestCacheLevel PolicyLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HttpCachePolicyElement()
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
