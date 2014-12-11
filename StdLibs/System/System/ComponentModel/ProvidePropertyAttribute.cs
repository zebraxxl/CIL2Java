using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ProvidePropertyAttribute : Attribute
    {
    
        public string PropertyName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ReceiverTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ProvidePropertyAttribute(string propertyName, Type receiverType)
        {
             throw new NotImplementedException();
        }
        
        
        public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
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
