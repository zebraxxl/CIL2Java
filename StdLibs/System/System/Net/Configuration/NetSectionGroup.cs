using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class NetSectionGroup : ConfigurationSectionGroup
    {
        [ConfigurationPropertyAttribute("authenticationModules")]
        public AuthenticationModulesSection AuthenticationModules
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("connectionManagement")]
        public ConnectionManagementSection ConnectionManagement
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("defaultProxy")]
        public DefaultProxySection DefaultProxy
        {
            get { throw new NotImplementedException(); }
        }
    
        public MailSettingsSectionGroup MailSettings
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("requestCaching")]
        public RequestCachingSection RequestCaching
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("settings")]
        public SettingsSection Settings
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("webRequestModules")]
        public WebRequestModulesSection WebRequestModules
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NetSectionGroup()
        {
             throw new NotImplementedException();
        }
        
        
        public static NetSectionGroup GetSectionGroup(System.Configuration.Configuration config)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
