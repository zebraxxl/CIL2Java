using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System;
using System.Collections;
using System.Security;

namespace System.Runtime.Remoting.Activation
{
    /// <summary>Represents the construction call request of an object.</summary>
    [ComVisibleAttribute(true)]
    public interface IConstructionCallMessage : IMethodCallMessage
    {
        /// <summary>Gets or sets the activator that activates the remote object.</summary><returns>The activator that activates the remote object.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IActivator Activator
        {
            get;
            set;
        }
    
        /// <summary>Gets the call site activation attributes.</summary><returns>The call site activation attributes.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        object[] CallSiteActivationAttributes
        {
            get;
        }
    
        /// <summary>Gets the full type name of the remote type to activate.</summary><returns>The full type name of the remote type to activate.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string ActivationTypeName
        {
            get;
        }
    
        /// <summary>Gets the type of the remote object to activate.</summary><returns>The type of the remote object to activate.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        Type ActivationType
        {
            get;
        }
    
        /// <summary>Gets a list of context properties that define the context in which the object is to be created.</summary><returns>A list of properties of the context in which to construct the object.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        IList ContextProperties
        {
            get;
        }
    
    
    }
}
