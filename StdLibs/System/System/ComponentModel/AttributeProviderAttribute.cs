using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class AttributeProviderAttribute : Attribute
    {
    
        public string TypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string PropertyName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AttributeProviderAttribute(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        public AttributeProviderAttribute(string typeName, string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
        public AttributeProviderAttribute(Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
