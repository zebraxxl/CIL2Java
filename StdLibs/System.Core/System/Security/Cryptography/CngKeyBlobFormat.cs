using System;

namespace System.Security.Cryptography
{
    [Serializable]
    public sealed class CngKeyBlobFormat : IEquatable<CngKeyBlobFormat>
    {
    
        public string Format
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngKeyBlobFormat EccPrivateBlob
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngKeyBlobFormat EccPublicBlob
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngKeyBlobFormat GenericPrivateBlob
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngKeyBlobFormat GenericPublicBlob
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngKeyBlobFormat OpaqueTransportBlob
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngKeyBlobFormat Pkcs8PrivateBlob
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CngKeyBlobFormat(string format)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(CngKeyBlobFormat left, CngKeyBlobFormat right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(CngKeyBlobFormat left, CngKeyBlobFormat right)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(CngKeyBlobFormat other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
