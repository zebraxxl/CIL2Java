using System.Security.Cryptography;
using System;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509ChainPolicy
    {
    
        public OidCollection ApplicationPolicy
        {
            get { throw new NotImplementedException(); }
        }
    
        public OidCollection CertificatePolicy
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509RevocationMode RevocationMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509RevocationFlag RevocationFlag
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509VerificationFlags VerificationFlags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public DateTime VerificationTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TimeSpan UrlRetrievalTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509Certificate2Collection ExtraStore
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509ChainPolicy()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
