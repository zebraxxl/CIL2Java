using System.Runtime.InteropServices;

namespace System.Threading
{
    /// <summary>Represents a method to be called within a new context.  </summary><param name="state">An object containing information to be used by the callback method each time it executes.</param><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    public delegate void ContextCallback(object state);
}
