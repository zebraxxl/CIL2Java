using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [DesignerCategoryAttribute("Component")]
    public class Component : MarshalByRefObject, IComponent
    {
    
        [BrowsableAttribute(false)]
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public event EventHandler Disposed;
    
    
        protected virtual bool CanRaiseEvents
        {
            get { throw new NotImplementedException(); }
        }
    
        protected EventHandlerList Events
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        public virtual ISite Site
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public IContainer Container
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        protected bool DesignMode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        ~Component()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual object GetService(Type service)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public Component()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
