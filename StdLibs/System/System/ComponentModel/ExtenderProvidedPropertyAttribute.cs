using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.All)]
    public sealed class ExtenderProvidedPropertyAttribute : Attribute
    {
    
        public PropertyDescriptor ExtenderProperty
        {
            get { throw new NotImplementedException(); }
        }
    
        public IExtenderProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type ReceiverType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ExtenderProvidedPropertyAttribute()
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
