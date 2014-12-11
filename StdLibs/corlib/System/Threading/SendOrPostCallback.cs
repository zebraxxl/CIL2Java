
namespace System.Threading
{
    /// <summary>Represents a method to be called when a message is to be dispatched to a synchronization context.  </summary><param name="state">The object passed to the delegate.</param><filterpriority>2</filterpriority>
    public delegate void SendOrPostCallback(object state);
}
