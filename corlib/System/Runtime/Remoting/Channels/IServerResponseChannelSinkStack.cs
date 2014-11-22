using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides the stack functionality for a stack of server response channel sinks.</summary>
    [ComVisibleAttribute(true)]
    public interface IServerResponseChannelSinkStack
    {
        /// <summary>Requests asynchronous processing of a method call on the sinks in the current sink stack.</summary><param name="msg">The response message.</param><param name="headers">The headers retrieved from the server response stream.</param><param name="stream">The stream coming back from the transport sink.</param>
        [SecurityCriticalAttribute()]
        void AsyncProcessResponse(IMessage msg, ITransportHeaders headers, Stream stream);
        
        
        /// <summary>Returns the <see cref="T:System.IO.Stream" /> onto which the specified message is to be serialized.</summary><returns>The <see cref="T:System.IO.Stream" /> onto which the specified message is to be serialized.</returns><param name="msg">The message to be serialized onto the requested stream. </param><param name="headers">The headers retrieved from the server response stream. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        Stream GetResponseStream(IMessage msg, ITransportHeaders headers);
        
        
    }
}
