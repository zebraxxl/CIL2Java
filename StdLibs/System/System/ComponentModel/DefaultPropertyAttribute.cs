using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class DefaultPropertyAttribute : Attribute
    {
        public static readonly DefaultPropertyAttribute Default;
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DefaultPropertyAttribute(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
