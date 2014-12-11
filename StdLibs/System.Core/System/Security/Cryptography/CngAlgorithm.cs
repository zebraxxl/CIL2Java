using System;

namespace System.Security.Cryptography
{
    [Serializable]
    public sealed class CngAlgorithm : IEquatable<CngAlgorithm>
    {
    
        public string Algorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm ECDiffieHellmanP256
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm ECDiffieHellmanP384
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm ECDiffieHellmanP521
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm ECDsaP256
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm ECDsaP384
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm ECDsaP521
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm MD5
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm Sha1
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm Sha256
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm Sha384
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithm Sha512
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CngAlgorithm(string algorithm)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(CngAlgorithm left, CngAlgorithm right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(CngAlgorithm left, CngAlgorithm right)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(CngAlgorithm other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
