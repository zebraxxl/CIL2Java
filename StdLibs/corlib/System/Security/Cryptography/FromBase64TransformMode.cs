using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Specifies whether white space should be ignored in the base 64 transformation.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum FromBase64TransformMode : int
    {
        /// <summary>White space should be ignored.</summary>
        IgnoreWhiteSpaces = 0,
        /// <summary>White space should not be ignored.</summary>
        DoNotIgnoreWhiteSpaces = 1
    }
}
