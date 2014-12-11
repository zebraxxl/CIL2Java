using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class WebRequestModulesSection : ConfigurationSection
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("", IsDefaultCollection = true)]
        public WebRequestModuleElementCollection WebRequestModules
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebRequestModulesSection()
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
