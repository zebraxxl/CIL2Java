using System;

namespace System.Security
{
    /// <summary>Identifies the source for the security context.</summary>
    public enum SecurityContextSource : int
    {
        /// <summary>The current application domain is the source for the security context.</summary>
        CurrentAppDomain = 0,
        /// <summary>The current assembly is the source for the security context.</summary>
        CurrentAssembly = 1
    }
}
