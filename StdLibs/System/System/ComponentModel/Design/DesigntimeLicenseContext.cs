using System.ComponentModel;
using System;
using System.Reflection;

namespace System.ComponentModel.Design
{
    public class DesigntimeLicenseContext : LicenseContext
    {
    
        public override LicenseUsageMode UsageMode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
        {
             throw new NotImplementedException();
        }
        
        
        public override void SetSavedLicenseKey(Type type, string key)
        {
             throw new NotImplementedException();
        }
        
        
        public DesigntimeLicenseContext()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
