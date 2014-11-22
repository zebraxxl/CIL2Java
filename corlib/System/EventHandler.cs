using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents the method that will handle an event that has no event data.</summary><param name="sender">The source of the event. </param><param name="e">An <see cref="T:System.EventArgs" /> that contains no event data. </param><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public delegate void EventHandler(object sender, EventArgs e);
}
