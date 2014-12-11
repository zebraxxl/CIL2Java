using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [DesignerCategoryAttribute("Component")]
    [DesignerAttribute("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
    [ComVisibleAttribute(true)]
    [TypeConverterAttribute(typeof(ComponentConverter))]
    public class MarshalByValueComponent : IComponent, IServiceProvider
    {
    
        public event EventHandler Disposed;
    
    
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
        public virtual IContainer Container
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        public virtual bool DesignMode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MarshalByValueComponent()
        {
             throw new NotImplementedException();
        }
        
        
        ~MarshalByValueComponent()
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
        
        
        public virtual object GetService(Type service)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
