using System.Runtime.InteropServices;
using System;

namespace System.Security.Policy
{
    /// <summary>Defines special attribute flags for security policy on code groups.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum PolicyStatementAttribute : int
    {
        /// <summary>No flags are set.</summary>
        Nothing = 0,
        /// <summary>The exclusive code group flag. When a code group has this flag set, only the permissions associated with that code group are granted to code belonging to the code group. At most, one code group matching a given piece of code can be set as exclusive.</summary>
        Exclusive = 1,
        /// <summary>The flag representing a policy statement that causes lower policy levels to not be evaluated as part of the resolve operation, effectively allowing the policy level to override lower levels.</summary>
        LevelFinal = 2,
        /// <summary>All attribute flags are set.</summary>
        All = 3
    }
}
