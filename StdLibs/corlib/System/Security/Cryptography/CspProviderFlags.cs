using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Specifies flags that modify the behavior of the cryptographic service providers (CSP).</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum CspProviderFlags : int
    {
        /// <summary>Do not specify any settings.</summary>
        NoFlags = 0,
        /// <summary>Use key information from the computer's key store.</summary>
        UseMachineKeyStore = 1,
        /// <summary>Use key information from the default key container.</summary>
        UseDefaultKeyContainer = 2,
        /// <summary>Use key information that cannot be exported.</summary>
        UseNonExportableKey = 4,
        /// <summary>Use key information from the current key.</summary>
        UseExistingKey = 8,
        /// <summary>Allow a key to be exported for archival or recovery.</summary>
        UseArchivableKey = 16,
        /// <summary>Notify the user through a dialog box or another method when certain actions are attempting to use a key.  This flag is not compatible with the <see cref="F:System.Security.Cryptography.CspProviderFlags.NoPrompt" /> flag.</summary>
        UseUserProtectedKey = 32,
        /// <summary>Prevent the CSP from displaying any user interface (UI) for this context.</summary>
        NoPrompt = 64,
        /// <summary>Create a temporary key that is released when the associated Rivest-Shamir-Adleman (RSA) object is closed. Do not use this flag if you want your key to be independent of the RSA object.</summary>
        CreateEphemeralKey = 128
    }
}
