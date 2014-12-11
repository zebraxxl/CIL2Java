using System;

namespace System.Security.Cryptography
{
    public struct CngProperty : IEquatable<CngProperty>
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public CngPropertyOptions Options
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CngProperty(string name, byte[] value, CngPropertyOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetValue()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(CngProperty left, CngProperty right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(CngProperty left, CngProperty right)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(CngProperty other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
