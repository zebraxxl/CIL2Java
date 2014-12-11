using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Indicates whether an <see cref="T:System.Threading.EventWaitHandle" /> is reset automatically or manually after receiving a signal.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(false)]
    public enum EventResetMode : int
    {
        /// <summary>When signaled, the <see cref="T:System.Threading.EventWaitHandle" /> resets automatically after releasing a single thread. If no threads are waiting, the <see cref="T:System.Threading.EventWaitHandle" /> remains signaled until a thread blocks, and resets after releasing the thread.</summary>
        AutoReset = 0,
        /// <summary>When signaled, the <see cref="T:System.Threading.EventWaitHandle" /> releases all waiting threads and remains signaled until it is manually reset.</summary>
        ManualReset = 1
    }
}
