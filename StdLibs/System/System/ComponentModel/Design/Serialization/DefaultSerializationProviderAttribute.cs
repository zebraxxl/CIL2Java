using System;

namespace System.ComponentModel.Design.Serialization
{
    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = false)]
    public sealed class DefaultSerializationProviderAttribute : Attribute
    {
    
        public string ProviderTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DefaultSerializationProviderAttribute(Type providerType)
        {
             throw new NotImplementedException();
        }
        
        
        public DefaultSerializationProviderAttribute(string providerTypeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
