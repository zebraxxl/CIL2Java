using System.Security;
using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Lifetime
{
    /// <summary>Controls the.NET remoting lifetime services.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public sealed class LifetimeServices
    {
    
        /// <summary>Gets or sets the initial lease time span for an <see cref="T:System.AppDomain" />.</summary><returns>The initial lease <see cref="T:System.TimeSpan" /> for objects that can have leases in the <see cref="T:System.AppDomain" />.</returns><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        public static TimeSpan LeaseTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the amount of time by which the lease is extended every time a call comes in on the server object.</summary><returns>The <see cref="T:System.TimeSpan" /> by which a lifetime lease in the current <see cref="T:System.AppDomain" /> is extended after each call.</returns><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        public static TimeSpan RenewOnCallTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the amount of time the lease manager waits for a sponsor to return with a lease renewal time.</summary><returns>The initial sponsorship time-out.</returns><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        public static TimeSpan SponsorshipTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the time interval between each activation of the lease manager to clean up expired leases.</summary><returns>The default amount of time the lease manager sleeps after checking for expired leases.</returns><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        public static TimeSpan LeaseManagerPollTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("Do not create instances of the LifetimeServices class.  Call the static methods directly on this type instead", true)]
        public LifetimeServices()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
