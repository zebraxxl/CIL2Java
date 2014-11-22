using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the access control rights that can be applied to named system mutex objects.</summary>
    [FlagsAttribute()]
    public enum MutexRights : int
    {
        /// <summary>The right to release a named mutex.</summary>
        Modify = 1,
        /// <summary>The right to delete a named mutex.</summary>
        Delete = 65536,
        /// <summary>The right to open and copy the access rules and audit rules for a named mutex.</summary>
        ReadPermissions = 131072,
        /// <summary>The right to change the security and audit rules associated with a named mutex.</summary>
        ChangePermissions = 262144,
        /// <summary>The right to change the owner of a named mutex.</summary>
        TakeOwnership = 524288,
        /// <summary>The right to wait on a named mutex.</summary>
        Synchronize = 1048576,
        /// <summary>The right to exert full control over a named mutex, and to modify its access rules and audit rules.</summary>
        FullControl = 2031617
    }
}
