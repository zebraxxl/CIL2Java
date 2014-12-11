using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Runtime.Remoting.Lifetime
{
    /// <summary>Indicates that the implementer wants to be a lifetime lease sponsor.</summary>
    [ComVisibleAttribute(true)]
    public interface ISponsor
    {
        /// <summary>Requests a sponsoring client to renew the lease for the specified object.</summary><returns>The additional lease time for the specified object.</returns><param name="lease">The lifetime lease of the object that requires lease renewal. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        TimeSpan Renewal(ILease lease);
        
        
    }
}
