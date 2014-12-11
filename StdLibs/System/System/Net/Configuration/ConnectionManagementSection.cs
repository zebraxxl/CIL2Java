using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class ConnectionManagementSection : ConfigurationSection
    {
    
        [ConfigurationPropertyAttribute("", IsDefaultCollection = true)]
        public ConnectionManagementElementCollection ConnectionManagement
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ConnectionManagementSection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
