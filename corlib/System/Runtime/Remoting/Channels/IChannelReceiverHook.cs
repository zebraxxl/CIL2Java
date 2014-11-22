using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Indicates that the implementing channel wants to hook into the outside listener service.</summary>
    [ComVisibleAttribute(true)]
    public interface IChannelReceiverHook
    {
        /// <summary>Gets the type of listener to hook into.</summary><returns>The type of listener to hook into (for example, "http").</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string ChannelScheme
        {
            get;
        }
    
        /// <summary>Gets a Boolean value that indicates whether <see cref="T:System.Runtime.Remoting.Channels.IChannelReceiverHook" /> needs to be hooked into the outside listener service.</summary><returns>A Boolean value that indicates whether <see cref="T:System.Runtime.Remoting.Channels.IChannelReceiverHook" /> needs to be hooked into the outside listener service.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        bool WantsToListen
        {
            get;
        }
    
        /// <summary>Gets the channel sink chain that the current channel is using.</summary><returns>The channel sink chain that the current channel is using.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IServerChannelSink ChannelSinkChain
        {
            get;
        }
    
    
        /// <summary>Adds a URI on which the channel hook will listen.</summary><param name="channelUri">A URI on which the channel hook will listen. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void AddHookChannelUri(string channelUri);
        
        
    }
}
