using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Event)]
    public class DisplayNameAttribute : Attribute
    {
        public static readonly DisplayNameAttribute Default;
    
        public virtual string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        protected string DisplayNameValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public DisplayNameAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public DisplayNameAttribute(string displayName)
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
