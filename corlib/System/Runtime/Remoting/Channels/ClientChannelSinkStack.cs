using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Holds the stack of client channel sinks that must be invoked during an asynchronous message response decoding.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public class ClientChannelSinkStack : IClientChannelSinkStack
    {
    
        public ClientChannelSinkStack()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Channels.ClientChannelSinkStack" /> class with the specified reply sink.</summary><param name="replySink">The <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> that the current stack can use to reply to messages. </param>
        public ClientChannelSinkStack(IMessageSink replySink)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Pushes the specified sink and information that is associated with it onto the sink stack.</summary><param name="sink">The sink to push onto the sink stack. </param><param name="state">Information generated on the request side that is needed on the response side. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void Push(IClientChannelSink sink, object state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Pops the information that is associated with all the sinks from the sink stack up to and including the specified sink.</summary><returns>Information generated on the request side and associated with the specified sink.</returns><param name="sink">The sink to remove and return from the sink stack. </param><exception cref="T:System.Runtime.Remoting.RemotingException">The current sink stack is empty, or the specified sink was never pushed onto the current stack. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public object Pop(IClientChannelSink sink)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Requests asynchronous processing of a method call on the sinks that are in the current sink stack.</summary><param name="headers">The headers that are retrieved from the server response stream. </param><param name="stream">The stream that is returning from the transport sink. </param><exception cref="T:System.Runtime.Remoting.RemotingException">The current sink stack is empty. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void AsyncProcessResponse(ITransportHeaders headers, Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Dispatches the specified reply message on the reply sink.</summary><param name="msg">The <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> to dispatch. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void DispatchReplyMessage(IMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Dispatches the specified exception on the reply sink.</summary><param name="e">The exception to dispatch to the server. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void DispatchException(Exception e)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
