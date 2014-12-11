using System.Configuration;
using System.ComponentModel;
using System;

namespace System.Net.Configuration
{
    public sealed class WebRequestModuleElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("prefix", IsRequired = true, IsKey = true)]
        public string Prefix
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("type")]
        public Type Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public WebRequestModuleElement()
        {
             throw new NotImplementedException();
        }
        
        
        public WebRequestModuleElement(string prefix, string type)
        {
             throw new NotImplementedException();
        }
        
        
        public WebRequestModuleElement(string prefix, Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
