using System.Security;

namespace System.Security.Cryptography
{
    public sealed class AesCryptoServiceProvider : Aes
    {
    
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
    
    
        [SecurityCriticalAttribute()]
        public AesCryptoServiceProvider()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override ICryptoTransform CreateDecryptor()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override ICryptoTransform CreateEncryptor()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void GenerateKey()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void GenerateIV()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
