using System;

namespace System.ComponentModel
{
    public abstract class InstanceCreationEditor
    {
        public virtual string Text
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);
        
        
        protected InstanceCreationEditor()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
