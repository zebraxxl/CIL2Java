using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class ListBindableAttribute : Attribute
    {
        public static readonly ListBindableAttribute Yes;
        public static readonly ListBindableAttribute No;
        public static readonly ListBindableAttribute Default;
    
        public bool ListBindable
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ListBindableAttribute(bool listBindable)
        {
             throw new NotImplementedException();
        }
        
        
        public ListBindableAttribute(BindableSupport flags)
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
