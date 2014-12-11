using System.Runtime.InteropServices;
using System;
using System.ComponentModel;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public sealed class ComponentChangedEventArgs : EventArgs
    {
    
        public object Component
        {
            get { throw new NotImplementedException(); }
        }
    
        public MemberDescriptor Member
        {
            get { throw new NotImplementedException(); }
        }
    
        public object NewValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public object OldValue
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComponentChangedEventArgs(object component, MemberDescriptor member, object oldValue, object newValue)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
