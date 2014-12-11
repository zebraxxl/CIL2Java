
namespace System.Configuration
{
    public sealed class ClientSettingsSection : ConfigurationSection
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("", IsDefaultCollection = true)]
        public SettingElementCollection Settings
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ClientSettingsSection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
