using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public sealed class NotifyParentPropertyAttribute : Attribute
    {
        public static readonly NotifyParentPropertyAttribute Yes;
        public static readonly NotifyParentPropertyAttribute No;
        public static readonly NotifyParentPropertyAttribute Default;
    
        public bool NotifyParent
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NotifyParentPropertyAttribute(bool notifyParent)
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
