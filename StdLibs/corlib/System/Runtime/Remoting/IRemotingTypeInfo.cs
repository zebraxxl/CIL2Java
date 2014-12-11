using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>Provides type information for an object.</summary>
    [ComVisibleAttribute(true)]
    public interface IRemotingTypeInfo
    {
        /// <summary>Gets or sets the fully qualified type name of the server object in a <see cref="T:System.Runtime.Remoting.ObjRef" />.</summary><returns>The fully qualified type name of the server object in a <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string TypeName
        {
            get;
            set;
        }
    
    
        /// <summary>Checks whether the proxy that represents the specified object type can be cast to the type represented by the <see cref="T:System.Runtime.Remoting.IRemotingTypeInfo" /> interface.</summary><returns>true if cast will succeed; otherwise, false.</returns><param name="fromType">The type to cast to. </param><param name="o">The object for which to check casting. </param><exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
        [SecurityCriticalAttribute()]
        bool CanCastTo(Type fromType, object o);
        
        
    }
}
