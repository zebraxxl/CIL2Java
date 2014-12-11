using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Represents the number of 100-nanosecond intervals since January 1, 1601. This structure is a 64-bit value.</summary>
    public struct FILETIME
    {
        /// <summary>Specifies the low 32 bits of the FILETIME.</summary>
        public int dwLowDateTime;
        /// <summary>Specifies the high 32 bits of the FILETIME.</summary>
        public int dwHighDateTime;
    
    }
}
