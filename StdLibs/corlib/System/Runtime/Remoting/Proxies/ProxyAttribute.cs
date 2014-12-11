using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Proxies
{
    /// <summary>Indicates that an object type requires a custom proxy.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class ProxyAttribute : Attribute, IContextAttribute
    {
        public ProxyAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates either an uninitialized <see cref="T:System.MarshalByRefObject" /> or a transparent proxy, depending on whether the specified type can exist in the current context.</summary><returns>An uninitialized <see cref="T:System.MarshalByRefObject" /> or a transparent proxy.</returns><param name="serverType">The object type to create an instance of. </param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual MarshalByRefObject CreateInstance(Type serverType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of a remoting proxy for a remote object described by the specified <see cref="T:System.Runtime.Remoting.ObjRef" />, and located on the server.</summary><returns>The new instance of remoting proxy for the remote object that is described in the specified <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns><param name="objRef">The object reference to the remote object for which to create a proxy. </param><param name="serverType">The type of the server where the remote object is located. </param><param name="serverObject">The server object. </param><param name="serverContext">The context in which the server object is located. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks the specified context.</summary><returns>The specified context.</returns><param name="ctx">The context to be verified.</param><param name="msg">The message for the remote call.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [ComVisibleAttribute(true)]
        [SecurityCriticalAttribute()]
        public bool IsContextOK(Context ctx, IConstructionCallMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets properties for a new context.</summary><param name="msg">The message for which the context is to be retrieved.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public void GetPropertiesForNewContext(IConstructionCallMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
