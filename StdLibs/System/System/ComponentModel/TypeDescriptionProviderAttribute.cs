using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = true)]
    public sealed class TypeDescriptionProviderAttribute : Attribute
    {
    
        public string TypeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TypeDescriptionProviderAttribute(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeDescriptionProviderAttribute(Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
