
namespace System.Security.Cryptography
{
    public abstract class ECDiffieHellman : AsymmetricAlgorithm
    {
        public override string KeyExchangeAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string SignatureAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public abstract ECDiffieHellmanPublicKey PublicKey
        {
            get;
        }
    
    
        public new static ECDiffieHellman Create()
        {
             throw new NotImplementedException();
        }
        
        
        public new static ECDiffieHellman Create(string algorithm)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey);
        
        
        protected ECDiffieHellman()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
