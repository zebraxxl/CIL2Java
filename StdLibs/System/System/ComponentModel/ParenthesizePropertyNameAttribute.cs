using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class ParenthesizePropertyNameAttribute : Attribute
    {
        public static readonly ParenthesizePropertyNameAttribute Default;
    
        public bool NeedParenthesis
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ParenthesizePropertyNameAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public ParenthesizePropertyNameAttribute(bool needParenthesis)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object o)
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
