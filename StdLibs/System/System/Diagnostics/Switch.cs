using System.Xml.Serialization;
using System.Collections.Specialized;

namespace System.Diagnostics
{
    public abstract class Switch
    {
        internal Switch()
        {
            //TODO: REMOVE THIS
        }
    
        [XmlIgnoreAttribute()]
        public StringDictionary Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Description
        {
            get { throw new NotImplementedException(); }
        }
    
        protected int SwitchSetting
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected string Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected Switch(string displayName, string description)
        {
             throw new NotImplementedException();
        }
        
        
        protected Switch(string displayName, string description, string defaultSwitchValue)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual string[] GetSupportedAttributes()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnSwitchSettingChanged()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnValueChanged()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
