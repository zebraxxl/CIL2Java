using System;

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
    public sealed class DesignerAttribute : Attribute
    {
    
        public string DesignerBaseTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string DesignerTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DesignerAttribute(string designerTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerAttribute(Type designerType)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerAttribute(string designerTypeName, Type designerBaseType)
        {
             throw new NotImplementedException();
        }
        
        
        public DesignerAttribute(Type designerType, Type designerBaseType)
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
