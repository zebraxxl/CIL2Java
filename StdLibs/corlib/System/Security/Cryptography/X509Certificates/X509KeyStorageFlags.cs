using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates
{
    /// <summary>Defines where and how to import the private key of an X.509 certificate.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum X509KeyStorageFlags : int
    {
        /// <summary>The default key set is used.  The user key set is usually the default. </summary>
        DefaultKeySet = 0,
        /// <summary>Private keys are stored in the current user store rather than the local computer store. This occurs even if the certificate specifies that the keys should go in the local computer store. </summary>
        UserKeySet = 1,
        /// <summary>Private keys are stored in the local computer store rather than the current user store. </summary>
        MachineKeySet = 2,
        /// <summary>Imported keys are marked as exportable.  </summary>
        Exportable = 4,
        /// <summary>Notify the user through a dialog box or other method that the key is accessed.  The Cryptographic Service Provider (CSP) in use defines the precise behavior.</summary>
        UserProtected = 8,
        /// <summary>The key associated with a PFX file is persisted when importing a certificate.</summary>
        PersistKeySet = 16
    }
}
