using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Describes the type of a variable, return type of a function, or the type of a function parameter.</summary>
    public struct TYPEDESC
    {
        /// <summary>If the variable is VT_SAFEARRAY or VT_PTR, the lpValue field contains a pointer to a TYPEDESC that specifies the element type.</summary>
        public IntPtr lpValue;
        /// <summary>Indicates the variant type for the item described by this TYPEDESC.</summary>
        public short vt;
    
    }
}
