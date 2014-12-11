using System;

namespace System.ComponentModel
{
    public sealed class LicenseManager
    {
    
        public static LicenseContext CurrentContext
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static LicenseUsageMode UsageMode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static object CreateWithContext(Type type, LicenseContext creationContext)
        {
             throw new NotImplementedException();
        }
        
        
        public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsLicensed(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsValid(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsValid(Type type, object instance, ref License license)
        {
             throw new NotImplementedException();
        }
        
        
        public static void LockContext(object contextUser)
        {
             throw new NotImplementedException();
        }
        
        
        public static void UnlockContext(object contextUser)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Validate(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static License Validate(Type type, object instance)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
