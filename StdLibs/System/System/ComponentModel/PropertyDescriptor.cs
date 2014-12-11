using System.Runtime.InteropServices;
using System;
using System.Collections;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public abstract class PropertyDescriptor : MemberDescriptor
    {
        internal PropertyDescriptor()
        {
            //TODO: REMOVE THIS
        }
    
        public abstract Type ComponentType
        {
            get;
        }
    
        public virtual TypeConverter Converter
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsLocalizable
        {
            get { throw new NotImplementedException(); }
        }
    
        public abstract bool IsReadOnly
        {
            get;
        }
    
        public DesignerSerializationVisibility SerializationVisibility
        {
            get { throw new NotImplementedException(); }
        }
    
        public abstract Type PropertyType
        {
            get;
        }
    
        public virtual bool SupportsChangeEvents
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected PropertyDescriptor(string name, Attribute[] attrs)
        {
             throw new NotImplementedException();
        }
        
        
        protected PropertyDescriptor(MemberDescriptor descr)
        {
             throw new NotImplementedException();
        }
        
        
        protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AddValueChanged(object component, EventHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract bool CanResetValue(object component);
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        protected object CreateInstance(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void FillAttributes(IList attributeList)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyDescriptorCollection GetChildProperties()
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyDescriptorCollection GetChildProperties(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object GetEditor(Type editorBaseType)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        protected override object GetInvocationTarget(Type type, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        protected Type GetTypeFromName(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract object GetValue(object component);
        
        
        protected virtual void OnValueChanged(object component, EventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RemoveValueChanged(object component, EventHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventHandler GetValueChangedHandler(object component)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void ResetValue(object component);
        
        
        public abstract void SetValue(object component, object value);
        
        
        public abstract bool ShouldSerializeValue(object component);
        
        
    }
}
