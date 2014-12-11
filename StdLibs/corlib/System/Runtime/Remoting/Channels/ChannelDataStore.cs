using System.Security;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
    /// <summary>Stores channel data for the remoting channels.</summary>
    [Serializable]
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class ChannelDataStore : IChannelDataStore
    {
    
        /// <summary>Gets or sets an array of channel URIs that the current channel maps to.</summary><returns>An array of channel URIs that the current channel maps to.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string[] ChannelUris
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the data object that is associated with the specified key for the implementing channel.</summary><returns>The specified data object for the implementing channel.</returns><param name="key">The key that the data object is associated with. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Channels.ChannelDataStore" /> class with the URIs that the current channel maps to.</summary><param name="channelURIs">An array of channel URIs that the current channel maps to. </param>
        public ChannelDataStore(string[] channelURIs)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
