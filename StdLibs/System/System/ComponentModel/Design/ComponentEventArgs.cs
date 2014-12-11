using System.Runtime.InteropServices;
using System;
using System.ComponentModel;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public class ComponentEventArgs : EventArgs
    {
    
        public virtual IComponent Component
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComponentEventArgs(IComponent component)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
