using System.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class PublicKey
    {
    
        public AsymmetricAlgorithm Key
        {
            get { throw new NotImplementedException(); }
        }
    
        public Oid Oid
        {
            get { throw new NotImplementedException(); }
        }
    
        public AsnEncodedData EncodedKeyValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public AsnEncodedData EncodedParameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
