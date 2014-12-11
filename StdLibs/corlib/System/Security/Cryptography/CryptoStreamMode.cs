using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Specifies the mode of a cryptographic stream.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum CryptoStreamMode : int
    {
        /// <summary>Read access to a cryptographic stream.</summary>
        Read = 0,
        /// <summary>Write access to a cryptographic stream.</summary>
        Write = 1
    }
}
