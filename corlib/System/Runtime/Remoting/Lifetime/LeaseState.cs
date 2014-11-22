using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Lifetime
{
    /// <summary>Indicates the possible lease states of a lifetime lease.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum LeaseState : int
    {
        /// <summary>The lease is not initialized.</summary>
        Null = 0,
        /// <summary>The lease has been created, but is not yet active.</summary>
        Initial = 1,
        /// <summary>The lease is active and has not expired.</summary>
        Active = 2,
        /// <summary>The lease has expired and is seeking sponsorship.</summary>
        Renewing = 3,
        /// <summary>The lease has expired and cannot be renewed.</summary>
        Expired = 4
    }
}
