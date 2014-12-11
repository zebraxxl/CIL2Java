using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Creates client channel sinks for the client channel through which remoting messages flow.</summary>
    [ComVisibleAttribute(true)]
    public interface IClientChannelSinkProvider
    {
        /// <summary>Gets or sets the next sink provider in the channel sink provider chain.</summary><returns>The next sink provider in the channel sink provider chain.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IClientChannelSinkProvider Next
        {
            get;
            set;
        }
    
    
        /// <summary>Creates a sink chain.</summary><returns>The first sink of the newly formed channel sink chain, or null, which indicates that this provider will not or cannot provide a connection for this endpoint.</returns><param name="channel">Channel for which the current sink chain is being constructed. </param><param name="url">The URL of the object to connect to. This parameter can be null if the connection is based entirely on the information contained in the <paramref name="remoteChannelData" /> parameter. </param><param name="remoteChannelData">A channel data object that describes a channel on the remote server. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData);
        
        
    }
}
