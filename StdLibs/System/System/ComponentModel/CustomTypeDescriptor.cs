using System;

namespace System.ComponentModel
{
    public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
    {
    
        protected CustomTypeDescriptor()
        {
             throw new NotImplementedException();
        }
        
        
        protected CustomTypeDescriptor(ICustomTypeDescriptor parent)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual AttributeCollection GetAttributes()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetClassName()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetComponentName()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual TypeConverter GetConverter()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptor GetDefaultEvent()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptor GetDefaultProperty()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object GetEditor(Type editorBaseType)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptorCollection GetEvents()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection GetProperties()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object GetPropertyOwner(PropertyDescriptor pd)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
