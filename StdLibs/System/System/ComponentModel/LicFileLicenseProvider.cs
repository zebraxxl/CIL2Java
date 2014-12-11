using System;

namespace System.ComponentModel
{
    public class LicFileLicenseProvider : LicenseProvider
    {
        protected virtual bool IsKeyValid(string key, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual string GetKey(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
        {
             throw new NotImplementedException();
        }
        
        
        public LicFileLicenseProvider()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
