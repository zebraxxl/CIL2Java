using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class DesignOnlyAttribute : Attribute
    {
        public static readonly DesignOnlyAttribute Yes;
        public static readonly DesignOnlyAttribute No;
        public static readonly DesignOnlyAttribute Default;
    
        public bool IsDesignOnly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignOnlyAttribute(bool isDesignOnly)
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
