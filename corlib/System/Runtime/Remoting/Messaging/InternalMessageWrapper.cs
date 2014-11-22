using System.Security;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Wraps remoting data for passing between message sinks, either for requests from client to server or for the subsequent responses.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class InternalMessageWrapper
    {
        /// <summary>Represents the request or response <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" /> interface that is wrapped by the message wrapper. </summary>
        protected IMessage WrappedMessage;
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.InternalMessageWrapper" /> class. </summary><param name="msg">A message that acts either as an outgoing method call on a remote object, or as the subsequent response.</param>
        public InternalMessageWrapper(IMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
