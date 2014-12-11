
namespace System.Security.Cryptography
{
    public abstract class ECDsa : AsymmetricAlgorithm
    {
        public override string KeyExchangeAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string SignatureAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public new static ECDsa Create()
        {
             throw new NotImplementedException();
        }
        
        
        public new static ECDsa Create(string algorithm)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract byte[] SignHash(byte[] hash);
        
        
        public abstract bool VerifyHash(byte[] hash, byte[] signature);
        
        
        protected ECDsa()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
