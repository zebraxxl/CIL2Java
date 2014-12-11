
namespace System.ComponentModel
{
    public abstract class ComponentEditor
    {
        public bool EditComponent(object component)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract bool EditComponent(ITypeDescriptorContext context, object component);
        
        
        protected ComponentEditor()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
