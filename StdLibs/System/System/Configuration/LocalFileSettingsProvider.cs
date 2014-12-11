using System.Collections.Specialized;

namespace System.Configuration
{
    public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
    {
    
        public override string ApplicationName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public void Initialize(string name, NameValueCollection values)
        {
             throw new NotImplementedException();
        }
        
        
        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
        {
             throw new NotImplementedException();
        }
        
        
        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset(SettingsContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
        {
             throw new NotImplementedException();
        }
        
        
        public LocalFileSettingsProvider()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
