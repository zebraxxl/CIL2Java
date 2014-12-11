using System.Runtime.InteropServices;

namespace System.Threading
{
    /// <summary>Represents the method that executes on a <see cref="T:System.Threading.Thread" />.</summary><param name="obj">An object that contains data for the thread procedure.</param><filterpriority>1</filterpriority>
    [ComVisibleAttribute(false)]
    public delegate void ParameterizedThreadStart(object obj);
}
