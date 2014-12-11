using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class ModuleElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("type")]
        public string Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ModuleElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
