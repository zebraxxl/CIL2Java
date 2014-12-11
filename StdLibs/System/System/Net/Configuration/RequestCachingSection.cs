using System.Configuration;
using System.Net.Cache;
using System;
using System.Xml;

namespace System.Net.Configuration
{
    public sealed class RequestCachingSection : ConfigurationSection
    {
    
        [ConfigurationPropertyAttribute("defaultHttpCachePolicy")]
        public HttpCachePolicyElement DefaultHttpCachePolicy
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("defaultFtpCachePolicy")]
        public FtpCachePolicyElement DefaultFtpCachePolicy
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("defaultPolicyLevel", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public RequestCacheLevel DefaultPolicyLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("disableAllCaching", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool DisableAllCaching
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("isPrivateCache", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool IsPrivateCache
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("unspecifiedMaximumAge", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public TimeSpan UnspecifiedMaximumAge
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RequestCachingSection()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
