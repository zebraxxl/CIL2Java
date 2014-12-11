using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class RefreshPropertiesAttribute : Attribute
    {
        public static readonly RefreshPropertiesAttribute All;
        public static readonly RefreshPropertiesAttribute Repaint;
        public static readonly RefreshPropertiesAttribute Default;
    
        public RefreshProperties RefreshProperties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RefreshPropertiesAttribute(RefreshProperties refresh)
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
        
        
    }
}
