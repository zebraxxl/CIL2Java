using System.Security;
using System.IO;

namespace System.Security.Cryptography
{
    public sealed class ECDsaCng : ECDsa
    {
    
        public CngAlgorithm HashAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CngKey Key
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ECDsaCng()
        {
             throw new NotImplementedException();
        }
        
        
        public ECDsaCng(int keySize)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public ECDsaCng(CngKey key)
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
        
        
        public byte[] SignData(byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public byte[] SignData(byte[] data, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public byte[] SignData(Stream data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override byte[] SignHash(byte[] hash)
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
        
        
        public bool VerifyData(byte[] data, byte[] signature)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool VerifyData(byte[] data, int offset, int count, byte[] signature)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool VerifyData(Stream data, byte[] signature)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override bool VerifyHash(byte[] hash, byte[] signature)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
