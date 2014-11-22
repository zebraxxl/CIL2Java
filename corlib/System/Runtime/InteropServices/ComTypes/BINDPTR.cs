using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Contains a pointer to a bound-to <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> structure, <see cref="T:System.Runtime.InteropServices.VARDESC" /> structure, or an ITypeComp interface.</summary>
    public struct BINDPTR
    {
        /// <summary>Represents a pointer to a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> structure.</summary>
        public IntPtr lpfuncdesc;
        /// <summary>Represents a pointer to a <see cref="T:System.Runtime.InteropServices.VARDESC" /> structure.</summary>
        public IntPtr lpvardesc;
        /// <summary>Represents a pointer to an <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeComp" /> interface.</summary>
        public IntPtr lptcomp;
    
    }
}
