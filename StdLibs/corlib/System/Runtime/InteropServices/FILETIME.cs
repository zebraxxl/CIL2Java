using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.FILETIME" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FILETIME instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct FILETIME
    {
        /// <summary>Specifies the low 32 bits of the FILETIME.</summary>
        public int dwLowDateTime;
        /// <summary>Specifies the high 32 bits of the FILETIME.</summary>
        public int dwHighDateTime;
    
    }
}
