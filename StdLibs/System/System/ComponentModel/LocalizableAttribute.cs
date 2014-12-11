using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class LocalizableAttribute : Attribute
    {
        public static readonly LocalizableAttribute Yes;
        public static readonly LocalizableAttribute No;
        public static readonly LocalizableAttribute Default;
    
        public bool IsLocalizable
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public LocalizableAttribute(bool isLocalizable)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsDefaultAttribute()
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
