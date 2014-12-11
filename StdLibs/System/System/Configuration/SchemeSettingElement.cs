using System;

namespace System.Configuration
{
    public sealed class SchemeSettingElement : ConfigurationElement
    {
    
        [ConfigurationPropertyAttribute("name", DefaultValue = null, IsRequired = true, IsKey = true)]
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        [ConfigurationPropertyAttribute("genericUriParserOptions", DefaultValue = ConfigurationPropertyOptions.None, IsRequired = true)]
        public GenericUriParserOptions GenericUriParserOptions
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SchemeSettingElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
