using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>Defines how well-known objects are activated.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum WellKnownObjectMode : int
    {
        /// <summary>Every incoming message is serviced by the same object instance.</summary>
        Singleton = 1,
        /// <summary>Every incoming message is serviced by a new object instance.</summary>
        SingleCall = 2
    }
}
