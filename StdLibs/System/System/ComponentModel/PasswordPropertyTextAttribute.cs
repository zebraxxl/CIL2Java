using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class PasswordPropertyTextAttribute : Attribute
    {
        public static readonly PasswordPropertyTextAttribute Yes;
        public static readonly PasswordPropertyTextAttribute No;
        public static readonly PasswordPropertyTextAttribute Default;
    
        public bool Password
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PasswordPropertyTextAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public PasswordPropertyTextAttribute(bool password)
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
