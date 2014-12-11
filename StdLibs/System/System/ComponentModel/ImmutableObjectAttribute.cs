using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class ImmutableObjectAttribute : Attribute
    {
        public static readonly ImmutableObjectAttribute Yes;
        public static readonly ImmutableObjectAttribute No;
        public static readonly ImmutableObjectAttribute Default;
    
        public bool Immutable
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ImmutableObjectAttribute(bool immutable)
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
        
        
        public override bool IsDefaultAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
