using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface)]
    public sealed class DesignTimeVisibleAttribute : Attribute
    {
        public static readonly DesignTimeVisibleAttribute Yes;
        public static readonly DesignTimeVisibleAttribute No;
        public static readonly DesignTimeVisibleAttribute Default;
    
        public bool Visible
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignTimeVisibleAttribute(bool visible)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignTimeVisibleAttribute()
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
