using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Specifies the type of padding to apply when the message data block is shorter than the full number of bytes needed for a cryptographic operation.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum PaddingMode : int
    {
        /// <summary>No padding is done.</summary>
        None = 1,
        /// <summary>The PKCS #7 padding string consists of a sequence of bytes, each of which is equal to the total number of padding bytes added. </summary>
        PKCS7 = 2,
        /// <summary>The padding string consists of bytes set to zero.</summary>
        Zeros = 3,
        /// <summary>The ANSIX923 padding string consists of a sequence of bytes filled with zeros before the length.</summary>
        ANSIX923 = 4,
        /// <summary>The ISO10126 padding string consists of random data before the length.</summary>
        ISO10126 = 5
    }
}
