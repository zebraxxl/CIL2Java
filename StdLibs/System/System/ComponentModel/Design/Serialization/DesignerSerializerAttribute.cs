using System;

namespace System.ComponentModel.Design.Serialization
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
    public sealed class DesignerSerializerAttribute : Attribute
    {
    
        public string SerializerTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string SerializerBaseTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignerSerializerAttribute(Type serializerType, Type baseSerializerType)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
