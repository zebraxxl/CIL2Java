using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies whether an <see cref="T:System.Security.AccessControl.AccessRule" /> object is used to allow or deny access. These values are not flags, and they cannot be combined.</summary>
    public enum AccessControlType : int
    {
        /// <summary>The <see cref="T:System.Security.AccessControl.AccessRule" /> object is used to allow access to a secured object.</summary>
        Allow = 0,
        /// <summary>The <see cref="T:System.Security.AccessControl.AccessRule" /> object is used to deny access to a secured object.</summary>
        Deny = 1
    }
}
