using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the cryptographic key operation for which an authorization rule controls access or auditing.</summary>
    [FlagsAttribute()]
    public enum CryptoKeyRights : int
    {
        /// <summary>Read the key data.</summary>
        ReadData = 1,
        /// <summary>Write key data.</summary>
        WriteData = 2,
        /// <summary>Read extended attributes of the key.</summary>
        ReadExtendedAttributes = 8,
        /// <summary>Write extended attributes of the key.</summary>
        WriteExtendedAttributes = 16,
        /// <summary>Read attributes of the key.</summary>
        ReadAttributes = 128,
        /// <summary>Write attributes of the key.</summary>
        WriteAttributes = 256,
        /// <summary>Delete the key.</summary>
        Delete = 65536,
        /// <summary>Read permissions for the key.</summary>
        ReadPermissions = 131072,
        /// <summary>Change permissions for the key.</summary>
        ChangePermissions = 262144,
        /// <summary>Take ownership of the key.</summary>
        TakeOwnership = 524288,
        /// <summary>Use the key for synchronization.</summary>
        Synchronize = 1048576,
        /// <summary>Full control of the key.</summary>
        FullControl = 2032027,
        /// <summary>A combination of <see cref="F:System.Security.AccessControl.CryptoKeyRights.GenericRead" /> and <see cref="F:System.Security.AccessControl.CryptoKeyRights.GenericWrite" />.</summary>
        GenericAll = 268435456,
        /// <summary>Not used.</summary>
        GenericExecute = 536870912,
        /// <summary>Write the key data, extended attributes of the key, attributes of the key, and permissions for the key.</summary>
        GenericWrite = 1073741824,
        /// <summary>Read the key data, extended attributes of the key, attributes of the key, and permissions for the key.</summary>
        GenericRead = -2147483648
    }
}
