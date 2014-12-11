using System.ComponentModel;

namespace System.Configuration
{
    public abstract class ApplicationSettingsBase : SettingsBase, INotifyPropertyChanged
    {
    
        public event PropertyChangedEventHandler PropertyChanged;
    
        public event SettingChangingEventHandler SettingChanging;
    
        public event SettingsLoadedEventHandler SettingsLoaded;
    
        public event SettingsSavingEventHandler SettingsSaving;
    
    
        [BrowsableAttribute(false)]
        public override SettingsContext Context
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public override SettingsPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public override SettingsPropertyValueCollection PropertyValues
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public override SettingsProviderCollection Providers
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public string SettingsKey
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override object this[string propertyName]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected ApplicationSettingsBase()
        {
             throw new NotImplementedException();
        }
        
        
        protected ApplicationSettingsBase(IComponent owner)
        {
             throw new NotImplementedException();
        }
        
        
        protected ApplicationSettingsBase(string settingsKey)
        {
             throw new NotImplementedException();
        }
        
        
        protected ApplicationSettingsBase(IComponent owner, string settingsKey)
        {
             throw new NotImplementedException();
        }
        
        
        public object GetPreviousVersion(string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnSettingsSaving(object sender, CancelEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void Reload()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Save()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Upgrade()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
