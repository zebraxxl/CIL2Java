using System;
using System.Reflection;

namespace System.ComponentModel
{
    public class LicenseContext : IServiceProvider
    {
        public virtual LicenseUsageMode UsageMode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object GetService(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void SetSavedLicenseKey(Type type, string key)
        {
             throw new NotImplementedException();
        }
        
        
        public LicenseContext()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
