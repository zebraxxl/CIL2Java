using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class LicenseProviderAttribute : Attribute
    {
        public static readonly LicenseProviderAttribute Default;
    
        public Type LicenseProvider
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public LicenseProviderAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public LicenseProviderAttribute(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        public LicenseProviderAttribute(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
