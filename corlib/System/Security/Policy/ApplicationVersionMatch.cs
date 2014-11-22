using System.Runtime.InteropServices;
using System;

namespace System.Security.Policy
{
    /// <summary>Specifies how to match versions when locating application trusts in a collection.</summary>
    [ComVisibleAttribute(true)]
    public enum ApplicationVersionMatch : int
    {
        /// <summary>Match on the exact version.</summary>
        MatchExactVersion = 0,
        /// <summary>Match on all versions.</summary>
        MatchAllVersions = 1
    }
}
