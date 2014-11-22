using System.Runtime.InteropServices;

namespace System.Threading
{
    /// <summary>Represents a callback method to be executed by a thread pool thread.</summary><param name="state">An object containing information to be used by the callback method. </param><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public delegate void WaitCallback(object state);
}
