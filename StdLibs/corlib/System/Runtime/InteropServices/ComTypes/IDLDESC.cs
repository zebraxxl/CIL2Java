using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Contains information needed for transferring a structure element, parameter, or function return value between processes.</summary>
    public struct IDLDESC
    {
        /// <summary>Reserved; set to null.</summary>
        public IntPtr dwReserved;
        /// <summary>Indicates an <see cref="T:System.Runtime.InteropServices.IDLFLAG" /> value describing the type.</summary>
        public IDLFLAG wIDLFlags;
    
    }
}
