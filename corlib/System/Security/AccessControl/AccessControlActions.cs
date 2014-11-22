using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the actions that are permitted for securable objects.</summary>
    [FlagsAttribute()]
    public enum AccessControlActions : int
    {
        /// <summary>Specifies no access.</summary>
        None = 0,
        /// <summary>Specifies read-only access.</summary>
        View = 1,
        /// <summary>Specifies write-only access.</summary>
        Change = 2
    }
}
