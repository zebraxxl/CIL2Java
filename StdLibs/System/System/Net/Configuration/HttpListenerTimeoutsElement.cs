using System.Configuration;
using System;

namespace System.Net.Configuration
{
    public sealed class HttpListenerTimeoutsElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("entityBody", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public TimeSpan EntityBody
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("drainEntityBody", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public TimeSpan DrainEntityBody
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("requestQueue", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public TimeSpan RequestQueue
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("idleConnection", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public TimeSpan IdleConnection
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("headerWait", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public TimeSpan HeaderWait
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("minSendBytesPerSecond", DefaultValue = Mono.Cecil.CustomAttributeArgument, IsRequired = false)]
        public long MinSendBytesPerSecond
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HttpListenerTimeoutsElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
