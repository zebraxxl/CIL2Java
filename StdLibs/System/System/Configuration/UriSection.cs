
namespace System.Configuration
{
    public sealed class UriSection : ConfigurationSection
    {
    
        [ConfigurationPropertyAttribute("idn")]
        public IdnElement Idn
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("iriParsing")]
        public IriParsingElement IriParsing
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("schemeSettings")]
        public SchemeSettingElementCollection SchemeSettings
        {
            get { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public UriSection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
