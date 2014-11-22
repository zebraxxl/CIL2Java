using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Stores the parameters that are used during a moniker binding operation.</summary>
    public struct BIND_OPTS
    {
        /// <summary>Specifies the size, in bytes, of the BIND_OPTS structure.</summary>
        public int cbStruct;
        /// <summary>Controls aspects of moniker binding operations.</summary>
        public int grfFlags;
        /// <summary>Represents flags that should be used when opening the file that contains the object identified by the moniker.</summary>
        public int grfMode;
        /// <summary>Indicates the amount of time (clock time in milliseconds, as returned by the GetTickCount function) that the caller specified to complete the binding operation.</summary>
        public int dwTickCountDeadline;
    
    }
}
