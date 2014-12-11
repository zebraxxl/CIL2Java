
namespace System.Configuration
{
    public sealed class SettingElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("name", IsRequired = true, IsKey = true, DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("serializeAs", IsRequired = true, DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public SettingsSerializeAs SerializeAs
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("value", IsRequired = true, DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public SettingValueElement Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SettingElement()
        {
             throw new NotImplementedException();
        }
        
        
        public SettingElement(string name, SettingsSerializeAs serializeAs)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object settings)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
