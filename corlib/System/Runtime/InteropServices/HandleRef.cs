using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Wraps a managed object holding a handle to a resource that is passed to unmanaged code using platform invoke.</summary>
    [ComVisibleAttribute(true)]
    public struct HandleRef
    {
    
        /// <summary>Gets the object holding the handle to a resource.</summary><returns>The object holding the handle to a resource.</returns>
        public object Wrapper
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the handle to a resource.</summary><returns>The handle to a resource.</returns>
        public IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.HandleRef" /> class with the object to wrap and a handle to the resource used by unmanaged code.</summary><param name="wrapper">A managed object that should not be finalized until the platform invoke call returns. </param><param name="handle">An <see cref="T:System.IntPtr" /> that indicates a handle to a resource. </param>
        public HandleRef(object wrapper, IntPtr handle)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator IntPtr(HandleRef value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the internal integer representation of a <see cref="T:System.Runtime.InteropServices.HandleRef" /> object.</summary><returns>An <see cref="T:System.IntPtr" /> object that represents a <see cref="T:System.Runtime.InteropServices.HandleRef" /> object.</returns><param name="value">A <see cref="T:System.Runtime.InteropServices.HandleRef" /> object to retrieve an internal integer representation from.</param>
        public static IntPtr ToIntPtr(HandleRef value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
