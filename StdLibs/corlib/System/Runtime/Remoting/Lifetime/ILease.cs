using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Runtime.Remoting.Lifetime
{
    /// <summary>Defines a lifetime lease object that is used by the remoting lifetime service.</summary>
    [ComVisibleAttribute(true)]
    public interface ILease
    {
        /// <summary>Gets or sets the amount of time by which a call to the remote object renews the <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</summary><returns>The amount of time by which a call to the remote object renews the <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        TimeSpan RenewOnCallTime
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the amount of time to wait for a sponsor to return with a lease renewal time.</summary><returns>The amount of time to wait for a sponsor to return with a lease renewal time.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        TimeSpan SponsorshipTimeout
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the initial time for the lease.</summary><returns>The initial time for the lease.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        TimeSpan InitialLeaseTime
        {
            get;
            set;
        }
    
        /// <summary>Gets the amount of time remaining on the lease.</summary><returns>The amount of time remaining on the lease.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        TimeSpan CurrentLeaseTime
        {
            get;
        }
    
        /// <summary>Gets the current <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" /> of the lease.</summary><returns>The current <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" /> of the lease.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        LeaseState CurrentState
        {
            get;
        }
    
    
        /// <summary>Registers a sponsor for the lease, and renews it by the specified <see cref="T:System.TimeSpan" />.</summary><param name="obj">The callback object of the sponsor. </param><param name="renewalTime">The length of time to renew the lease by. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        void Register(ISponsor obj, TimeSpan renewalTime);
        
        
        /// <summary>Registers a sponsor for the lease without renewing the lease.</summary><param name="obj">The callback object of the sponsor. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        void Register(ISponsor obj);
        
        
        /// <summary>Removes a sponsor from the sponsor list.</summary><param name="obj">The lease sponsor to unregister. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        void Unregister(ISponsor obj);
        
        
        /// <summary>Renews a lease for the specified time.</summary><returns>The new expiration time of the lease.</returns><param name="renewalTime">The length of time to renew the lease by. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        TimeSpan Renew(TimeSpan renewalTime);
        
        
    }
}
