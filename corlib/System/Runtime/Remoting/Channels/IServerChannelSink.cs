using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides methods used for security and transport sinks.</summary>
    [ComVisibleAttribute(true)]
    public interface IServerChannelSink : IChannelSinkBase
    {
        /// <summary>Gets the next server channel sink in the server sink chain.</summary><returns>The next server channel sink in the server sink chain.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have the required <see cref="F:System.Security.Permissions.SecurityPermissionFlag.Infrastructure" /> permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IServerChannelSink NextChannelSink
        {
            get;
        }
    
    
        [SecurityCriticalAttribute()]
        ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, ref IMessage responseMsg, ref ITransportHeaders responseHeaders, ref Stream responseStream);
        
        
        /// <summary>Requests processing from the current sink of the response from a method call sent asynchronously.</summary><param name="sinkStack">A stack of sinks leading back to the server transport sink. </param><param name="state">Information generated on the request side that is associated with this sink. </param><param name="msg">The response message. </param><param name="headers">The headers to add to the return message heading to the client. </param><param name="stream">The stream heading back to the transport sink. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream);
        
        
        /// <summary>Returns the <see cref="T:System.IO.Stream" /> onto which the provided response message is to be serialized.</summary><returns>The <see cref="T:System.IO.Stream" /> onto which the provided response message is to be serialized.</returns><param name="sinkStack">A stack of sinks leading back to the server transport sink. </param><param name="state">The state that has been pushed to the stack by this sink. </param><param name="msg">The response message to serialize. </param><param name="headers">The headers to put in the response stream to the client. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers);
        
        
    }
}
