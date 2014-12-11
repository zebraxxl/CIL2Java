using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Represents the class that describes how to marshal a field from managed to unmanaged code. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed class UnmanagedMarshal
    {
    
        /// <summary>Indicates an unmanaged type. This property is read-only.</summary><returns>An <see cref="T:System.Runtime.InteropServices.UnmanagedType" /> object.</returns>
        public UnmanagedType GetUnmanagedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a GUID. This property is read-only.</summary><returns>A <see cref="T:System.Guid" /> object.</returns><exception cref="T:System.ArgumentException">The argument is not a custom marshaler. </exception>
        public Guid IIDGuid
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a number element. This property is read-only.</summary><returns>An integer indicating the element count.</returns><exception cref="T:System.ArgumentException">The argument is not an unmanaged element count. </exception>
        public int ElementCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an unmanaged base type. This property is read-only.</summary><returns>An UnmanagedType object.</returns><exception cref="T:System.ArgumentException">The unmanaged type is not an LPArray or a SafeArray. </exception>
        public UnmanagedType BaseType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Specifies a given type that is to be marshaled to unmanaged code.</summary><returns>An <see cref="T:System.Reflection.Emit.UnmanagedMarshal" /> object.</returns><param name="unmanagedType">The unmanaged type to which the type is to be marshaled. </param><exception cref="T:System.ArgumentException">The argument is not a simple native type. </exception>
        public static UnmanagedMarshal DefineUnmanagedMarshal(UnmanagedType unmanagedType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a string in a fixed array buffer (ByValTStr) to marshal to unmanaged code.</summary><returns>An <see cref="T:System.Reflection.Emit.UnmanagedMarshal" /> object.</returns><param name="elemCount">The number of elements in the fixed array buffer. </param><exception cref="T:System.ArgumentException">The argument is not a simple native type. </exception>
        public static UnmanagedMarshal DefineByValTStr(int elemCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a SafeArray to marshal to unmanaged code.</summary><returns>An <see cref="T:System.Reflection.Emit.UnmanagedMarshal" /> object.</returns><param name="elemType">The base type or the UnmanagedType of each element of the array. </param><exception cref="T:System.ArgumentException">The argument is not a simple native type. </exception>
        public static UnmanagedMarshal DefineSafeArray(UnmanagedType elemType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a fixed-length array (ByValArray) to marshal to unmanaged code.</summary><returns>An <see cref="T:System.Reflection.Emit.UnmanagedMarshal" /> object.</returns><param name="elemCount">The number of elements in the fixed-length array. </param><exception cref="T:System.ArgumentException">The argument is not a simple native type. </exception>
        public static UnmanagedMarshal DefineByValArray(int elemCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies an LPArray to marshal to unmanaged code. The length of an LPArray is determined at runtime by the size of the actual marshaled array.</summary><returns>An <see cref="T:System.Reflection.Emit.UnmanagedMarshal" /> object.</returns><param name="elemType">The unmanaged type to which to marshal the array. </param><exception cref="T:System.ArgumentException">The argument is not a simple native type. </exception>
        public static UnmanagedMarshal DefineLPArray(UnmanagedType elemType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
