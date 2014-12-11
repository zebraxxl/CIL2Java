using System.ComponentModel;

namespace System.Configuration
{
    public class SettingChangingEventArgs : CancelEventArgs
    {
    
        public object NewValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public string SettingClass
        {
            get { throw new NotImplementedException(); }
        }
    
        public string SettingName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string SettingKey
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
