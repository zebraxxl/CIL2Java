using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Specifies whether to create an asymmetric signature key or an asymmetric exchange key. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum KeyNumber : int
    {
        /// <summary>An exchange key pair used to encrypt session keys so that they can be safely stored and exchanged with other users.  </summary>
        Exchange = 1,
        /// <summary>A signature key pair used for authenticating digitally signed messages or files.</summary>
        Signature = 2
    }
}
