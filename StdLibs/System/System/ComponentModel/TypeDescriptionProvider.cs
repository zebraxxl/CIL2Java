using System;
using System.Collections;

namespace System.ComponentModel
{
    public abstract class TypeDescriptionProvider
    {
    
        protected TypeDescriptionProvider()
        {
             throw new NotImplementedException();
        }
        
        
        protected TypeDescriptionProvider(TypeDescriptionProvider parent)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IDictionary GetCache(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual IExtenderProvider[] GetExtenderProviders(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetFullComponentName(object component)
        {
             throw new NotImplementedException();
        }
        
        
        public Type GetReflectionType(Type objectType)
        {
             throw new NotImplementedException();
        }
        
        
        public Type GetReflectionType(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Type GetReflectionType(Type objectType, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Type GetRuntimeType(Type reflectionType)
        {
             throw new NotImplementedException();
        }
        
        
        public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
        {
             throw new NotImplementedException();
        }
        
        
        public ICustomTypeDescriptor GetTypeDescriptor(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool IsSupportedType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
