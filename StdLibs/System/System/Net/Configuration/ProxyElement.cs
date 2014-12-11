using System.Configuration;
using System;

namespace System.Net.Configuration
{
    public sealed class ProxyElement : ConfigurationElement
    {
        public enum BypassOnLocalValues : int
        {
            Unspecified = -1,
            False = 0,
            True = 1
        }
    
        public enum UseSystemDefaultValues : int
        {
            Unspecified = -1,
            False = 0,
            True = 1
        }
    
        public enum AutoDetectValues : int
        {
            Unspecified = -1,
            False = 0,
            True = 1
        }
    
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("autoDetect", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public AutoDetectValues AutoDetect
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("scriptLocation")]
        public Uri ScriptLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("bypassonlocal", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public BypassOnLocalValues BypassOnLocal
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("proxyaddress")]
        public Uri ProxyAddress
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("usesystemdefault", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public UseSystemDefaultValues UseSystemDefault
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ProxyElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
