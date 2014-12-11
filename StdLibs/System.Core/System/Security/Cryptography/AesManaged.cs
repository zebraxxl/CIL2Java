
namespace System.Security.Cryptography
{
    public sealed class AesManaged : Aes
    {
    
        public override int FeedbackSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override byte[] IV
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override byte[] Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override int KeySize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override CipherMode Mode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override PaddingMode Padding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AesManaged()
        {
             throw new NotImplementedException();
        }
        
        
        public override ICryptoTransform CreateDecryptor()
        {
             throw new NotImplementedException();
        }
        
        
        public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
        {
             throw new NotImplementedException();
        }
        
        
        public override ICryptoTransform CreateEncryptor()
        {
             throw new NotImplementedException();
        }
        
        
        public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GenerateIV()
        {
             throw new NotImplementedException();
        }
        
        
        public override void GenerateKey()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
