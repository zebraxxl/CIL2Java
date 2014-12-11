using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Describes how to transfer a structure element, parameter, or function return value between processes.</summary>
    [Serializable]
    [FlagsAttribute()]
    public enum IDLFLAG : short
    {
        /// <summary>Does not specify whether the parameter passes or receives information.</summary>
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
