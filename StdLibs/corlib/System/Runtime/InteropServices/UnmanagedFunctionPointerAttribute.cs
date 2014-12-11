using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Controls the marshaling behavior of a delegate signature passed as an unmanaged function pointer to or from unmanaged code. This class cannot be inherited. </summary>
    [AttributeUsageAttribute(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class UnmanagedFunctionPointerAttribute : Attribute
    {
        /// <summary>Indicates how to marshal string parameters to the method, and controls name mangling.</summary>
        public CharSet CharSet;
        /// <summary>Enables or disables best-fit mapping behavior when converting Unicode characters to ANSI characters.</summary>
        public bool BestFitMapping;
        /// <summary>Enables or disables the throwing of an exception on an unmappable Unicode character that is converted to an ANSI "?" character.</summary>
        public bool ThrowOnUnmappableChar;
        /// <summary>Indicates whether the callee calls the SetLastError Win32 API function before returning from the attributed method.</summary>
        public bool SetLastError;
    
        /// <summary>Gets the value of the calling convention.</summary><returns>The value of the calling convention specified by the <see cref="M:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute.#ctor(System.Runtime.InteropServices.CallingConvention)" /> constructor.</returns>
        public CallingConvention CallingConvention
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute" /> class with the specified calling convention. </summary><param name="callingConvention">The specified calling convention.</param>
        public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
