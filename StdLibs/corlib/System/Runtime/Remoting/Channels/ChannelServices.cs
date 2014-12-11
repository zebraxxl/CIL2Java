using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides static methods to aid with remoting channel registration, resolution, and URL discovery. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class ChannelServices
    {
    
        /// <summary>Gets a list of currently registered channels.</summary><returns>An array of all the currently registered channels.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static IChannel[] RegisteredChannels
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Registers a channel with the channel services.</summary><param name="chnl">The channel to register.</param><param name="ensureSecurity">true ensures that security is enabled; otherwise false. Setting the value to false does not effect the security setting on the TCP or IPC channel. </param><exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is null. </exception><exception cref="T:System.Runtime.Remoting.RemotingException">The channel has already been registered. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the call stack does not have permission to configure remoting types and channels. </exception><exception cref="T:System.NotSupportedException">Not supported in Windows 98 for <see cref="T:System.Runtime.Remoting.Channels.Tcp.TcpServerChannel" /> and on all platforms for <see cref="T:System.Runtime.Remoting.Channels.Http.HttpServerChannel" />. Host the service using Internet Information Services (IIS) if you require a secure HTTP channel.</exception>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers a channel with the channel services. <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel)" /> is obsolete. Please use <see cref="M:System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(System.Runtime.Remoting.Channels.IChannel,System.Boolean)" /> instead.</summary><param name="chnl">The channel to register. </param><exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is null. </exception><exception cref="T:System.Runtime.Remoting.RemotingException">The channel has already been registered. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Use System.Runtime.Remoting.ChannelServices.RegisterChannel(IChannel chnl, bool ensureSecurity) instead.", false)]
        public static void RegisterChannel(IChannel chnl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unregisters a particular channel from the registered channels list.</summary><param name="chnl">The channel to unregister. </param><exception cref="T:System.ArgumentNullException">The <paramref name="chnl" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The channel is not registered. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void UnregisterChannel(IChannel chnl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a registered channel with the specified name.</summary><returns>An interface to a registered channel, or null if the channel is not registered.</returns><param name="name">The channel name. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IChannel GetChannel(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of all the URLs that can be used to reach the specified object.</summary><returns>An array of strings that contains the URLs that can be used to remotely identify the object, or null if none were found.</returns><param name="obj">The object to retrieve the URL array for. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string[] GetUrlsForObject(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Collections.IDictionary" /> of properties for a given proxy.</summary><returns>An interface to the dictionary of properties, or null if no properties were found.</returns><param name="obj">The proxy to retrieve properties for. </param><exception cref="T:System.Security.SecurityException">At least one of the callers that is higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IDictionary GetChannelSinkProperties(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static ServerProcessing DispatchMessage(IServerChannelSinkStack sinkStack, IMessage msg, ref IMessage replyMsg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Synchronously dispatches the incoming message to the server-side chain(s) based on the URI embedded in the message.</summary><returns>A reply message is returned by the call to the server-side chain.</returns><param name="msg">The message to dispatch. </param><exception cref="T:System.ArgumentNullException">The <paramref name="msg" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IMessage SyncDispatchMessage(IMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Asynchronously dispatches the given message to the server-side chain(s) based on the URI embedded in the message.</summary><returns>A <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> object used to control the asynchronously dispatched message.</returns><param name="msg">The message to dispatch. </param><param name="replySink">The sink that will process the return message if it is not null. </param><exception cref="T:System.ArgumentNullException">The <paramref name="msg" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IMessageCtrl AsyncDispatchMessage(IMessage msg, IMessageSink replySink)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a channel sink chain for the specified channel.</summary><returns>A new channel sink chain for the specified channel.</returns><param name="provider">The first provider in the chain of sink providers that will create the channel sink chain. </param><param name="channel">The <see cref="T:System.Runtime.Remoting.Channels.IChannelReceiver" /> for which to create the channel sink chain. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IServerChannelSink CreateServerChannelSinkChain(IServerChannelSinkProvider provider, IChannelReceiver channel)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
