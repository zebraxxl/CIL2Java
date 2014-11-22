using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Remoting
{
    /// <summary>Wraps marshal-by-value object references, allowing them to be returned through an indirection.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDual)]
    public class ObjectHandle : MarshalByRefObject, IObjectHandle
    {
    
        /// <summary>Initializes an instance of the <see cref="T:System.Runtime.Remoting.ObjectHandle" /> class, wrapping the given object <paramref name="o" />.</summary><param name="o">The object that is wrapped by the new <see cref="T:System.Runtime.Remoting.ObjectHandle" />. </param>
        public ObjectHandle(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public object Unwrap()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override object InitializeLifetimeService()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
