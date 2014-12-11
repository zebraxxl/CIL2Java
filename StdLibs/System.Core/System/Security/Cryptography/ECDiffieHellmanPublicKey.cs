using System;

namespace System.Security.Cryptography
{
    [Serializable]
    public abstract class ECDiffieHellmanPublicKey : IDisposable
    {
    
        protected ECDiffieHellmanPublicKey(byte[] keyBlob)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual byte[] ToByteArray()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract string ToXmlString();
        
        
    }
}
