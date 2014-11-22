using System.Runtime.InteropServices;

namespace System
{
    /// <summary>References a method to be called when a corresponding asynchronous operation completes.</summary><param name="ar">The result of the asynchronous operation. </param><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public delegate void AsyncCallback(IAsyncResult ar);
}
