using System.Runtime.InteropServices;
using System;
using System.ComponentModel;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public sealed class ComponentChangingEventArgs : EventArgs
    {
    
        public object Component
        {
            get { throw new NotImplementedException(); }
        }
    
        public MemberDescriptor Member
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComponentChangingEventArgs(object component, MemberDescriptor member)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
