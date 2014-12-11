using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Provides a way to control asynchronous messages after they have dispatched using the <see cref="M:System.Runtime.Remoting.Messaging.IMessageSink.AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage,System.Runtime.Remoting.Messaging.IMessageSink)" />.</summary>
    [ComVisibleAttribute(true)]
    public interface IMessageCtrl
    {
        /// <summary>Cancels an asynchronous call.</summary><param name="msToCancel">The number of milliseconds after which to cancel the message. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void Cancel(int msToCancel);
        
        
    }
}
