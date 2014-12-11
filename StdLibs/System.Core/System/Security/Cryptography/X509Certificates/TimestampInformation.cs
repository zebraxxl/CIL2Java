using System;
using System.Security.Cryptography;
using System.Security;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class TimestampInformation
    {
    
        public string HashAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public int HResult
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsValid
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509Chain SignatureChain
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509Certificate2 SigningCertificate
        {
            get { throw new NotImplementedException(); }
        }
    
        public DateTime Timestamp
        {
            get { throw new NotImplementedException(); }
        }
    
        public SignatureVerificationResult VerificationResult
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
