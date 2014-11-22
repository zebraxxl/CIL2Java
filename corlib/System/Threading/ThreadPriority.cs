using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Specifies the scheduling priority of a <see cref="T:System.Threading.Thread" />.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ThreadPriority : int
    {
        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with any other priority.</summary>
        Lowest = 0,
        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with Normal priority and before those with Lowest priority.</summary>
        BelowNormal = 1,
        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with AboveNormal priority and before those with BelowNormal priority. Threads have Normal priority by default.</summary>
        Normal = 2,
        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with Highest priority and before those with Normal priority.</summary>
        AboveNormal = 3,
        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled before threads with any other priority.</summary>
        Highest = 4
    }
}
