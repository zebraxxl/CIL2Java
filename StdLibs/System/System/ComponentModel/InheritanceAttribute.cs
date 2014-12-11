using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Event)]
    public sealed class InheritanceAttribute : Attribute
    {
        public static readonly InheritanceAttribute Inherited;
        public static readonly InheritanceAttribute InheritedReadOnly;
        public static readonly InheritanceAttribute NotInherited;
        public static readonly InheritanceAttribute Default;
    
        public InheritanceLevel InheritanceLevel
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public InheritanceAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public InheritanceAttribute(InheritanceLevel inheritanceLevel)
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
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
