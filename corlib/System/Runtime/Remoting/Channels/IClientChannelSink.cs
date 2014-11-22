using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides required functions and properties for client channel sinks.</summary>
    [ComVisibleAttribute(true)]
    public interface IClientChannelSink : IChannelSinkBase
    {
        /// <summary>Gets the next client channel sink in the client sink chain.</summary><returns>The next client channel sink in the client sink chain.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IClientChannelSink NextChannelSink
        {
            get;
        }
    
    
        [SecurityCriticalAttribute()]
        void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, ref ITransportHeaders responseHeaders, ref Stream responseStream);
        
        
        /// <summary>Requests asynchronous processing of a method call on the current sink.</summary><param name="sinkStack">A stack of channel sinks that called this sink. </param><param name="msg">The message to process. </param><param name="headers">The headers to add to the outgoing message heading to the server. </param><param name="stream">The stream headed to the transport sink. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream);
        
        
        /// <summary>Requests asynchronous processing of a response to a method call on the current sink.</summary><param name="sinkStack">A stack of sinks that called this sink. </param><param name="state">Information generated on the request side that is associated with this sink. </param><param name="headers">The headers retrieved from the server response stream. </param><param name="stream">The stream coming back from the transport sink. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream);
        
        
        /// <summary>Returns the <see cref="T:System.IO.Stream" /> onto which the provided message is to be serialized.</summary><returns>The <see cref="T:System.IO.Stream" /> onto which the provided message is to be serialized.</returns><param name="msg">The <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> containing details about the method call. </param><param name="headers">The headers to add to the outgoing message heading to the server. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        Stream GetRequestStream(IMessage msg, ITransportHeaders headers);
        
        
    }
}
