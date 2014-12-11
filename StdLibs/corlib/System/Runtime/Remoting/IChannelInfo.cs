using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting
{
    /// <summary>Provides custom channel information that is carried along with the <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary>
    [ComVisibleAttribute(true)]
    public interface IChannelInfo
    {
        /// <summary>Gets and sets the channel data for each channel.</summary><returns>The channel data for each channel.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object[] ChannelData
        {
            get;
            set;
        }
    
    
    }
}
