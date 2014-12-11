using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Activation
{
    /// <summary>Provides the basic functionality for a remoting activator class.</summary>
    [ComVisibleAttribute(true)]
    public interface IActivator
    {
        /// <summary>Gets or sets the next activator in the chain.</summary><returns>The next activator in the chain.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IActivator NextActivator
        {
            get;
            set;
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.Remoting.Activation.ActivatorLevel" /> where this activator is active.</summary><returns>The <see cref="T:System.Runtime.Remoting.Activation.ActivatorLevel" /> where this activator is active.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        ActivatorLevel Level
        {
            get;
        }
    
    
        /// <summary>Creates an instance of the object that is specified in the provided <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary><returns>Status of the object activation contained in a <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />.</returns><param name="msg">The information about the object that is needed to activate it, stored in a <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        IConstructionReturnMessage Activate(IConstructionCallMessage msg);
        
        
    }
}
