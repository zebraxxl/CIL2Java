using System.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509BasicConstraintsExtension : X509Extension
    {
    
        public bool CertificateAuthority
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool HasPathLengthConstraint
        {
            get { throw new NotImplementedException(); }
        }
    
        public int PathLengthConstraint
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509BasicConstraintsExtension()
        {
             throw new NotImplementedException();
        }
        
        
        public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public override void CopyFrom(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
