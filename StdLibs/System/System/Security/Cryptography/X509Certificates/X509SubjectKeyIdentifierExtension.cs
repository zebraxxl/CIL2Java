using System.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509SubjectKeyIdentifierExtension : X509Extension
    {
    
        public string SubjectKeyIdentifier
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509SubjectKeyIdentifierExtension()
        {
             throw new NotImplementedException();
        }
        
        
        public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public override void CopyFrom(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
