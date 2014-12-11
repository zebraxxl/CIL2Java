using System;

namespace System.Security.Cryptography
{
    [Serializable]
    public sealed class CngProvider : IEquatable<CngProvider>
    {
    
        public string Provider
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngProvider MicrosoftSmartCardKeyStorageProvider
        {
            get { throw new NotImplementedException(); }
        }
    
        public static CngProvider MicrosoftSoftwareKeyStorageProvider
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CngProvider(string provider)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(CngProvider left, CngProvider right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(CngProvider left, CngProvider right)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(CngProvider other)
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
