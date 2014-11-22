using System.Runtime.InteropServices;
using System;

namespace System.Security.Policy
{
    /// <summary>Specifies the type of user interface (UI) the trust manager should use for trust decisions. </summary>
    [ComVisibleAttribute(true)]
    public enum TrustManagerUIContext : int
    {
        /// <summary>An Install UI.</summary>
        Install = 0,
        /// <summary>An Upgrade UI.</summary>
        Upgrade = 1,
        /// <summary>A Run UI.</summary>
        Run = 2
    }
}
