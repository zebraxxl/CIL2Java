using System.Security;

namespace System.Security.Cryptography
{
    [Serializable]
    public sealed class ECDiffieHellmanCngPublicKey : ECDiffieHellmanPublicKey
    {
        internal ECDiffieHellmanCngPublicKey()
            : base(null)
        {}
    
        public CngKeyBlobFormat BlobFormat
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static ECDiffieHellmanPublicKey FromByteArray(byte[] publicKeyBlob, CngKeyBlobFormat format)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static ECDiffieHellmanCngPublicKey FromXmlString(string xml)
        {
             throw new NotImplementedException();
        }
        
        
        public CngKey Import()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToXmlString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
