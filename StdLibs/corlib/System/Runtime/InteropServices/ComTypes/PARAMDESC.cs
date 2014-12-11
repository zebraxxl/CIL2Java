using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Contains information about how to transfer a structure element, parameter, or function return value between processes.</summary>
    public struct PARAMDESC
    {
        /// <summary>Represents a pointer to a value that is being passed between processes.</summary>
        public IntPtr lpVarValue;
        /// <summary>Represents bitmask values that describe the structure element, parameter, or return value.</summary>
        public PARAMFLAG wParamFlags;
    
    }
}
