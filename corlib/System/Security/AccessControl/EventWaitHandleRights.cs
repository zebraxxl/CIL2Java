using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the access control rights that can be applied to named system event objects.</summary>
    [FlagsAttribute()]
    public enum EventWaitHandleRights : int
    {
        /// <summary>The right to set or reset the signaled state of a named event.</summary>
        Modify = 2,
        /// <summary>The right to delete a named event.</summary>
        Delete = 65536,
        /// <summary>The right to open and copy the access rules and audit rules for a named event.</summary>
        ReadPermissions = 131072,
        /// <summary>The right to change the security and audit rules associated with a named event.</summary>
        ChangePermissions = 262144,
        /// <summary>The right to change the owner of a named event.</summary>
        TakeOwnership = 524288,
        /// <summary>The right to wait on a named event.</summary>
        Synchronize = 1048576,
        /// <summary>The right to exert full control over a named event, and to modify its access rules and audit rules.</summary>
        FullControl = 2031619
    }
}
