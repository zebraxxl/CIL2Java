using System.ComponentModel;

namespace System.Configuration
{
    public abstract class SettingsBase
    {
    
        public virtual object this[string propertyName]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual SettingsPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual SettingsProviderCollection Providers
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual SettingsPropertyValueCollection PropertyValues
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual SettingsContext Context
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected SettingsBase()
        {
             throw new NotImplementedException();
        }
        
        
        public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Save()
        {
             throw new NotImplementedException();
        }
        
        
        public static SettingsBase Synchronized(SettingsBase settingsBase)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
