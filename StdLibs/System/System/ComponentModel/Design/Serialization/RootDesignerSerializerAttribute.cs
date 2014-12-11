using System;

namespace System.ComponentModel.Design.Serialization
{
    [ObsoleteAttribute("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  http://go.microsoft.com/fwlink/?linkid=14202")]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
    public sealed class RootDesignerSerializerAttribute : Attribute
    {
    
        public bool Reloadable
        {
            get { throw new NotImplementedException(); }
        }
    
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
    
    
        public RootDesignerSerializerAttribute(Type serializerType, Type baseSerializerType, bool reloadable)
        {
             throw new NotImplementedException();
        }
        
        
        public RootDesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType, bool reloadable)
        {
             throw new NotImplementedException();
        }
        
        
        public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
