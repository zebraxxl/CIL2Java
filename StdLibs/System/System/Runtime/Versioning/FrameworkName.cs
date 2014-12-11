using System;

namespace System.Runtime.Versioning
{
    [Serializable]
    public sealed class FrameworkName : IEquatable<FrameworkName>
    {
    
        public string Identifier
        {
            get { throw new NotImplementedException(); }
        }
    
        public Version Version
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Profile
        {
            get { throw new NotImplementedException(); }
        }
    
        public string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(FrameworkName other)
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
        
        
        public FrameworkName(string identifier, Version version)
        {
             throw new NotImplementedException();
        }
        
        
        public FrameworkName(string identifier, Version version, string profile)
        {
             throw new NotImplementedException();
        }
        
        
        public FrameworkName(string frameworkName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(FrameworkName left, FrameworkName right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(FrameworkName left, FrameworkName right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
