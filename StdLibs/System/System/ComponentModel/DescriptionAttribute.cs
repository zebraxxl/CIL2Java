using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {
        public static readonly DescriptionAttribute Default;
    
        public virtual string Description
        {
            get { throw new NotImplementedException(); }
        }
    
        protected string DescriptionValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public DescriptionAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public DescriptionAttribute(string description)
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
