using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class BrowsableAttribute : Attribute
    {
        public static readonly BrowsableAttribute Yes;
        public static readonly BrowsableAttribute No;
        public static readonly BrowsableAttribute Default;
    
        public bool Browsable
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public BrowsableAttribute(bool browsable)
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
