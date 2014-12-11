using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class DefaultBindingPropertyAttribute : Attribute
    {
        public static readonly DefaultBindingPropertyAttribute Default;
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DefaultBindingPropertyAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public DefaultBindingPropertyAttribute(string name)
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
