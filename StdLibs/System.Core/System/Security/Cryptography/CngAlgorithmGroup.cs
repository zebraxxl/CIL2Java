using System;

namespace System.Security.Cryptography
{
    [Serializable]
    public sealed class CngAlgorithmGroup : IEquatable<CngAlgorithmGroup>
    {
    
        public string AlgorithmGroup
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithmGroup DiffieHellman
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithmGroup Dsa
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithmGroup ECDiffieHellman
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithmGroup ECDsa
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngAlgorithmGroup Rsa
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CngAlgorithmGroup(string algorithmGroup)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(CngAlgorithmGroup left, CngAlgorithmGroup right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(CngAlgorithmGroup left, CngAlgorithmGroup right)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(CngAlgorithmGroup other)
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
