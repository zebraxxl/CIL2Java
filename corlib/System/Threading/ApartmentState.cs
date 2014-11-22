using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Specifies the apartment state of a <see cref="T:System.Threading.Thread" />.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ApartmentState : int
    {
        /// <summary>The <see cref="T:System.Threading.Thread" /> will create and enter a single-threaded apartment.</summary>
        STA = 0,
        /// <summary>The <see cref="T:System.Threading.Thread" /> will create and enter a multithreaded apartment.</summary>
        MTA = 1,
        /// <summary>The <see cref="P:System.Threading.Thread.ApartmentState" /> property has not been set.</summary>
        Unknown = 2
    }
}
