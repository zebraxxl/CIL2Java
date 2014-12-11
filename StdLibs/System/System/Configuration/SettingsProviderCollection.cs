using System.Configuration.Provider;

namespace System.Configuration
{
    public class SettingsProviderCollection : ProviderCollection
    {
        public new SettingsProvider this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override void Add(ProviderBase provider)
        {
             throw new NotImplementedException();
        }
        
        
        public SettingsProviderCollection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
