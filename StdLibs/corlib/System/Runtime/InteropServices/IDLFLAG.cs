using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IDLFLAG" /> instead. </summary>
    [Serializable]
    [FlagsAttribute()]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IDLFLAG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum IDLFLAG : short
    {
        /// <summary>Whether the parameter passes or receives information is unspecified.</summary>
        IDLFLAG_NONE = 0,
        /// <summary>The parameter passes information from the caller to the callee.</summary>
        IDLFLAG_FIN = 1,
        /// <summary>The parameter returns information from the callee to the caller.</summary>
        IDLFLAG_FOUT = 2,
        /// <summary>The parameter is the local identifier of a client application.</summary>
        IDLFLAG_FLCID = 4,
        /// <summary>The parameter is the return value of the member.</summary>
        IDLFLAG_FRETVAL = 8
    }
}
