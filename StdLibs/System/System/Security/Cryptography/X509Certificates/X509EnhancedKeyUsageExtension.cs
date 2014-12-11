using System.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509EnhancedKeyUsageExtension : X509Extension
    {
    
        public OidCollection EnhancedKeyUsages
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509EnhancedKeyUsageExtension()
        {
             throw new NotImplementedException();
        }
        
        
        public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public override void CopyFrom(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
