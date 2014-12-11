using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography
{
    public sealed class ECDiffieHellmanCng : ECDiffieHellman
    {
    
        public CngAlgorithm HashAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public byte[] HmacKey
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ECDiffieHellmanKeyDerivationFunction KeyDerivationFunction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public byte[] Label
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public byte[] SecretAppend
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public byte[] SecretPrepend
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public byte[] Seed
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CngKey Key
        {
            get { throw new NotImplementedException(); }
        }
    
        public override ECDiffieHellmanPublicKey PublicKey
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool UseSecretAgreementAsHmacKey
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ECDiffieHellmanCng()
        {
             throw new NotImplementedException();
        }
        
        
        public ECDiffieHellmanCng(int keySize)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public ECDiffieHellmanCng(CngKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public override byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public byte[] DeriveKeyMaterial(CngKey otherPartyPublicKey)
        {
             throw new NotImplementedException();
        }
        
        
        public SafeNCryptSecretHandle DeriveSecretAgreementHandle(ECDiffieHellmanPublicKey otherPartyPublicKey)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public SafeNCryptSecretHandle DeriveSecretAgreementHandle(CngKey otherPartyPublicKey)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void FromXmlString(string xmlString)
        {
             throw new NotImplementedException();
        }
        
        
        public void FromXmlString(string xml, ECKeyXmlFormat format)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToXmlString(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToXmlString(ECKeyXmlFormat format)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
