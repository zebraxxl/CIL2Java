using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class BindableAttribute : Attribute
    {
        public static readonly BindableAttribute Yes;
        public static readonly BindableAttribute No;
        public static readonly BindableAttribute Default;
    
        public bool Bindable
        {
            get { throw new NotImplementedException(); }
        }
    
        public BindingDirection Direction
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public BindableAttribute(bool bindable)
        {
             throw new NotImplementedException();
        }
        
        
        public BindableAttribute(bool bindable, BindingDirection direction)
        {
             throw new NotImplementedException();
        }
        
        
        public BindableAttribute(BindableSupport flags)
        {
             throw new NotImplementedException();
        }
        
        
        public BindableAttribute(BindableSupport flags, BindingDirection direction)
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
