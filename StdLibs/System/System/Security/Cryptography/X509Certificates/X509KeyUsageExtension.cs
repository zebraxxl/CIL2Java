using System.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509KeyUsageExtension : X509Extension
    {
    
        public X509KeyUsageFlags KeyUsages
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509KeyUsageExtension()
        {
             throw new NotImplementedException();
        }
        
        
        public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public override void CopyFrom(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
