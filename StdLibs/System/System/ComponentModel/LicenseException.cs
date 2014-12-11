using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
    [Serializable]
    public class LicenseException : SystemException
    {
    
        public Type LicensedType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public LicenseException(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public LicenseException(Type type, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public LicenseException(Type type, object instance, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public LicenseException(Type type, object instance, string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected LicenseException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
