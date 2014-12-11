using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class SettingsSection : ConfigurationSection
    {
    
        [ConfigurationPropertyAttribute("httpWebRequest")]
        public HttpWebRequestElement HttpWebRequest
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("ipv6")]
        public Ipv6Element Ipv6
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("servicePointManager")]
        public ServicePointManagerElement ServicePointManager
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("socket")]
        public SocketElement Socket
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("webProxyScript")]
        public WebProxyScriptElement WebProxyScript
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("performanceCounters")]
        public PerformanceCountersElement PerformanceCounters
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("httpListener")]
        public HttpListenerElement HttpListener
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("webUtility")]
        public WebUtilityElement WebUtility
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsSection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
