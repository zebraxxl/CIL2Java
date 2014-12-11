using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public class ComponentRenameEventArgs : EventArgs
    {
    
        public object Component
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string OldName
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string NewName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComponentRenameEventArgs(object component, string oldName, string newName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
