using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class AuthenticationModulesSection : ConfigurationSection
    {
    
        [ConfigurationPropertyAttribute("", IsDefaultCollection = true)]
        public AuthenticationModuleElementCollection AuthenticationModules
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AuthenticationModulesSection()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void InitializeDefault()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
