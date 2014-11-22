using System.Runtime.InteropServices;
using System;

namespace System.Threading
{
    /// <summary>Specifies the execution states of a <see cref="T:System.Threading.Thread" />.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum ThreadState : int
    {
        /// <summary>The thread has been started, it is not blocked, and there is no pending <see cref="T:System.Threading.ThreadAbortException" />.</summary>
        Running = 0,
        /// <summary>The thread is being requested to stop. This is for internal use only.</summary>
        StopRequested = 1,
        /// <summary>The thread is being requested to suspend.</summary>
        SuspendRequested = 2,
        /// <summary>The thread is being executed as a background thread, as opposed to a foreground thread. This state is controlled by setting the <see cref="P:System.Threading.Thread.IsBackground" /> property.</summary>
        Background = 4,
        /// <summary>The <see cref="M:System.Threading.Thread.Start" /> method has not been invoked on the thread.</summary>
        Unstarted = 8,
        /// <summary>The thread has stopped.</summary>
        Stopped = 16,
        /// <summary>The thread is blocked. This could be the result of calling <see cref="M:System.Threading.Thread.Sleep(System.Int32)" /> or <see cref="M:System.Threading.Thread.Join" />, of requesting a lock — for example, by calling <see cref="M:System.Threading.Monitor.Enter(System.Object)" /> or <see cref="M:System.Threading.Monitor.Wait(System.Object,System.Int32,System.Boolean)" /> — or of waiting on a thread synchronization object such as <see cref="T:System.Threading.ManualResetEvent" />. </summary>
        WaitSleepJoin = 32,
        /// <summary>The thread has been suspended.</summary>
        Suspended = 64,
        /// <summary>The <see cref="M:System.Threading.Thread.Abort(System.Object)" /> method has been invoked on the thread, but the thread has not yet received the pending <see cref="T:System.Threading.ThreadAbortException" /> that will attempt to terminate it.</summary>
        AbortRequested = 128,
        /// <summary>The thread state includes <see cref="F:System.Threading.ThreadState.AbortRequested" /> and the thread is now dead, but its state has not yet changed to <see cref="F:System.Threading.ThreadState.Stopped" />.</summary>
        Aborted = 256
    }
}
