using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Defines the interface for a message sink.</summary>
    [ComVisibleAttribute(true)]
    public interface IMessageSink
    {
        /// <summary>Gets the next message sink in the sink chain.</summary><returns>The next message sink in the sink chain.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IMessageSink NextSink
        {
            get;
        }
    
    
        /// <summary>Synchronously processes the given message.</summary><returns>A reply message in response to the request.</returns><param name="msg">The message to process. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        IMessage SyncProcessMessage(IMessage msg);
        
        
        /// <summary>Asynchronously processes the given message.</summary><returns>Returns an <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> interface that provides a way to control asynchronous messages after they have been dispatched.</returns><param name="msg">The message to process. </param><param name="replySink">The reply sink for the reply message. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
        
        
    }
}
