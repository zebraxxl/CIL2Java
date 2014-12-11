using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class DefaultEventAttribute : Attribute
    {
        public static readonly DefaultEventAttribute Default;
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DefaultEventAttribute(string name)
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
