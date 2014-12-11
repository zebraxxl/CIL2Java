using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class MergablePropertyAttribute : Attribute
    {
        public static readonly MergablePropertyAttribute Yes;
        public static readonly MergablePropertyAttribute No;
        public static readonly MergablePropertyAttribute Default;
    
        public bool AllowMerge
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MergablePropertyAttribute(bool allowMerge)
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
