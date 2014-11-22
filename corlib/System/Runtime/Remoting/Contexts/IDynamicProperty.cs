using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Indicates that the implementing property should be registered at runtime through the <see cref="M:System.Runtime.Remoting.Contexts.Context.RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty,System.ContextBoundObject,System.Runtime.Remoting.Contexts.Context)" /> method.</summary>
    [ComVisibleAttribute(true)]
    public interface IDynamicProperty
    {
        /// <summary>Gets the name of the dynamic property.</summary><returns>The name of the dynamic property.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        string Name
        {
            get;
        }
    
    
    }
}
