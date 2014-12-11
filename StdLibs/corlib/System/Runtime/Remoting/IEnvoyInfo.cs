using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting
{
    /// <summary>Provides envoy information.</summary>
    [ComVisibleAttribute(true)]
    public interface IEnvoyInfo
    {
        /// <summary>Gets or sets the list of envoys that were contributed by the server context and object chains when the object was marshaled.</summary><returns>A chain of envoy sinks.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IMessageSink EnvoySinks
        {
            get;
            set;
        }
    
    
    }
}
