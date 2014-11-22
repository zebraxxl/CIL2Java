using System.Runtime.InteropServices;

namespace System.Threading
{
    /// <summary>Represents the method that handles calls from a <see cref="T:System.Threading.Timer" />.</summary><param name="state">An object containing application-specific information relevant to the method invoked by this delegate, or null. </param><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public delegate void TimerCallback(object state);
}
