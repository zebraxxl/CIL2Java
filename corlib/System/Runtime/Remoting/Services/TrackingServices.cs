using System.Security;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
    /// <summary>Provides a way to register, unregister, and obtain a list of tracking handlers.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class TrackingServices
    {
    
        /// <summary>Gets an array of the tracking handlers that are currently registered with <see cref="T:System.Runtime.Remoting.Services.TrackingServices" /> in the current <see cref="T:System.AppDomain" />.</summary><returns>An array of the tracking handlers that are currently registered with <see cref="T:System.Runtime.Remoting.Services.TrackingServices" /> in the current <see cref="T:System.AppDomain" />.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static ITrackingHandler[] RegisteredHandlers
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Registers a new tracking handler with the <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />.</summary><param name="handler">The tracking handler to register. </param><exception cref="T:System.ArgumentNullException"><paramref name="handler" /> is null. </exception><exception cref="T:System.Runtime.Remoting.RemotingException">The handler that is indicated in the <paramref name="handler" /> parameter is already registered with <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void RegisterTrackingHandler(ITrackingHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Unregisters the specified tracking handler from <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />.</summary><param name="handler">The handler to unregister. </param><exception cref="T:System.ArgumentNullException"><paramref name="handler" /> is null. </exception><exception cref="T:System.Runtime.Remoting.RemotingException">The handler that is indicated in the <paramref name="handler" /> parameter is not registered with <see cref="T:System.Runtime.Remoting.Services.TrackingServices" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void UnregisterTrackingHandler(ITrackingHandler handler)
        {
             throw new NotImplementedException();
        }
        
        
        public TrackingServices()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
