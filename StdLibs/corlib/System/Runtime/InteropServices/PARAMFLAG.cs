using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.PARAMFLAG" /> instead.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.PARAMFLAG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum PARAMFLAG : short
    {
        /// <summary>Whether the parameter passes or receives information is unspecified.</summary>
        PARAMFLAG_NONE = 0,
        /// <summary>The parameter passes information from the caller to the callee.</summary>
        PARAMFLAG_FIN = 1,
        /// <summary>The parameter returns information from the callee to the caller.</summary>
        PARAMFLAG_FOUT = 2,
        /// <summary>The parameter is the local identifier of a client application.</summary>
        PARAMFLAG_FLCID = 4,
        /// <summary>The parameter is the return value of the member.</summary>
        PARAMFLAG_FRETVAL = 8,
        /// <summary>The parameter is optional.</summary>
        PARAMFLAG_FOPT = 16,
        /// <summary>The parameter has default behaviors defined.</summary>
        PARAMFLAG_FHASDEFAULT = 32,
        /// <summary>The parameter has custom data.</summary>
        PARAMFLAG_FHASCUSTDATA = 64
    }
}
