using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.BIND_OPTS" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.BIND_OPTS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct BIND_OPTS
    {
        /// <summary>Specifies the size of the BIND_OPTS structure in bytes.</summary>
        public int cbStruct;
        /// <summary>Controls aspects of moniker binding operations.</summary>
        public int grfFlags;
        /// <summary>Flags that should be used when opening the file that contains the object identified by the moniker.</summary>
        public int grfMode;
        /// <summary>Indicates the amount of time (clock time in milliseconds, as returned by the GetTickCount function) the caller specified to complete the binding operation.</summary>
        public int dwTickCountDeadline;
    
    }
}
