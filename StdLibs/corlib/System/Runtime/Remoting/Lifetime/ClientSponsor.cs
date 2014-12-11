using System.Security;
using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting.Lifetime
{
    /// <summary>Provides a default implementation for a lifetime sponsor class.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class ClientSponsor : MarshalByRefObject, ISponsor
    {
    
        /// <summary>Gets or sets the <see cref="T:System.TimeSpan" /> by which to increase the lifetime of the sponsored objects when renewal is requested.</summary><returns>The <see cref="T:System.TimeSpan" /> by which to increase the lifetime of the sponsored objects when renewal is requested.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public TimeSpan RenewalTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ClientSponsor()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" /> class with the renewal time of the sponsored object.</summary><param name="renewalTime">The <see cref="T:System.TimeSpan" /> by which to increase the lifetime of the sponsored objects when renewal is requested. </param>
        public ClientSponsor(TimeSpan renewalTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers the specified <see cref="T:System.MarshalByRefObject" /> for sponsorship.</summary><returns>true if registration succeeded; otherwise, false.</returns><param name="obj">The object to register for sponsorship with the <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" />. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public bool Register(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unregisters the specified <see cref="T:System.MarshalByRefObject" /> from the list of objects sponsored by the current <see cref="T:System.Runtime.Remoting.Lifetime.ClientSponsor" />.</summary><param name="obj">The object to unregister. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void Unregister(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Requests a sponsoring client to renew the lease for the specified object.</summary><returns>The additional lease time for the specified object.</returns><param name="lease">The lifetime lease of the object that requires lease renewal. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public TimeSpan Renewal(ILease lease)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override object InitializeLifetimeService()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        ~ClientSponsor()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
