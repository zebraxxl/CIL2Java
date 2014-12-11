using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
    /// <summary>Defines the privileges of the user account associated with the access token. </summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum TokenAccessLevels : int
    {
        /// <summary>The user can attach a primary token to a process.</summary>
        AssignPrimary = 1,
        /// <summary>The user can duplicate the token.</summary>
        Duplicate = 2,
        /// <summary>The user can impersonate a client.</summary>
        Impersonate = 4,
        /// <summary>The user can query the token.</summary>
        Query = 8,
        /// <summary>The user can query the source of the token.</summary>
        QuerySource = 16,
        /// <summary>The user can enable or disable privileges in the token.</summary>
        AdjustPrivileges = 32,
        /// <summary>The user can change the attributes of the groups in the token.</summary>
        AdjustGroups = 64,
        /// <summary>The user can change the default owner, primary group, or discretionary access control list (DACL) of the token.</summary>
        AdjustDefault = 128,
        /// <summary>The user can adjust the session identifier of the token.</summary>
        AdjustSessionId = 256,
        /// <summary>The user has standard read rights and the <see cref="F:System.Security.Principal.TokenAccessLevels.Query" /> privilege for the token.</summary>
        Read = 131080,
        /// <summary>The user has standard write rights and the <see cref="F:System.Security.Principal.TokenAccessLevels.AdjustPrivileges,F:System.Security.Principal.TokenAccessLevels.AdjustGroups" />, and <see cref="F:System.Security.Principal.TokenAccessLevels.AdjustDefault" /> privileges for the token.</summary>
        Write = 131296,
        /// <summary>The user has all possible access to the token.</summary>
        AllAccess = 983551,
        /// <summary>The maximum value that can be assigned for the <see cref="T:System.Security.Principal.TokenAccessLevels" /> enumeration.</summary>
        MaximumAllowed = 33554432
    }
}
