using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS" /> instead.</summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [FlagsAttribute()]
    public enum IMPLTYPEFLAGS : int
    {
        /// <summary>The interface or dispinterface represents the default for the source or sink.</summary>
        IMPLTYPEFLAG_FDEFAULT = 1,
        /// <summary>This member of a coclass is called rather than implemented.</summary>
        IMPLTYPEFLAG_FSOURCE = 2,
        /// <summary>The member should not be displayed or programmable by users.</summary>
        IMPLTYPEFLAG_FRESTRICTED = 4,
        /// <summary>Sinks receive events through the virtual function table (VTBL).</summary>
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8
    }
}
