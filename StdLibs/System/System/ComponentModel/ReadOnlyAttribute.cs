using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class ReadOnlyAttribute : Attribute
    {
        public static readonly ReadOnlyAttribute Yes;
        public static readonly ReadOnlyAttribute No;
        public static readonly ReadOnlyAttribute Default;
    
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ReadOnlyAttribute(bool isReadOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object value)
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
