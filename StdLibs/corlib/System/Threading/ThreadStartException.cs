using System;

namespace System.Threading
{
    /// <summary>The exception that is thrown when a failure occurs in a managed thread after the underlying operating system thread has been started, but before the thread is ready to execute user code.</summary>
    [Serializable]
    public sealed class ThreadStartException : SystemException
    {
    }
}
