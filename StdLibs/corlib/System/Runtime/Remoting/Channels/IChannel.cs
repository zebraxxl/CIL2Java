using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Provides conduits for messages that cross remoting boundaries.</summary>
    [ComVisibleAttribute(true)]
    public interface IChannel
    {
        /// <summary>Gets the priority of the channel.</summary><returns>An integer that indicates the priority of the channel.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        int ChannelPriority
        {
            get;
        }
    
        /// <summary>Gets the name of the channel.</summary><returns>The name of the channel.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string ChannelName
        {
            get;
        }
    
    
        [SecurityCriticalAttribute()]
        string Parse(string url, ref string objectURI);
        
        
    }
}
