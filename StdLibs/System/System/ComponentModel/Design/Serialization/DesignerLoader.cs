using System.Runtime.InteropServices;

namespace System.ComponentModel.Design.Serialization
{
    [ComVisibleAttribute(true)]
    public abstract class DesignerLoader
    {
        public virtual bool Loading
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public abstract void BeginLoad(IDesignerLoaderHost host);
        
        
        public abstract void Dispose();
        
        
        public virtual void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        protected DesignerLoader()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
