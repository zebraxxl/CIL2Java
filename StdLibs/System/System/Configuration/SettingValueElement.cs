using System.Xml;

namespace System.Configuration
{
    public sealed class SettingValueElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        public XmlNode ValueXml
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object settingValue)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsModified()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void ResetModified()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Reset(ConfigurationElement parentElement)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingValueElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
