using System;

namespace System.Windows.Markup
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
    public sealed class ValueSerializerAttribute : Attribute
    {
    
        public Type ValueSerializerType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ValueSerializerTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ValueSerializerAttribute(Type valueSerializerType)
        {
             throw new NotImplementedException();
        }
        
        
        public ValueSerializerAttribute(string valueSerializerTypeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
