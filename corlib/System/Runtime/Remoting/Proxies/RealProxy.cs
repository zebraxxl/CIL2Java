using System.Security;
using System.Runtime.InteropServices;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Proxies
{
    /// <summary>Provides base functionality for proxies.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public abstract class RealProxy
    {
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class that represents a remote object of the specified <see cref="T:System.Type" />.</summary><param name="classToProxy">The <see cref="T:System.Type" /> of the remote object for which to create a proxy. </param><exception cref="T:System.ArgumentException"><paramref name="classToProxy" /> is not an interface, and is not derived from <see cref="T:System.MarshalByRefObject" />. </exception>
        [SecurityCriticalAttribute()]
        protected RealProxy(Type classToProxy)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class.</summary><param name="classToProxy">The <see cref="T:System.Type" /> of the remote object for which to create a proxy. </param><param name="stub">A stub to associate with the new proxy instance. </param><param name="stubData">The stub data to set for the specified stub and the new proxy instance. </param><exception cref="T:System.ArgumentException"><paramref name="classToProxy" /> is not an interface, and is not derived from <see cref="T:System.MarshalByRefObject" />. </exception>
        [SecurityCriticalAttribute()]
        protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the object <see cref="T:System.Type" /> of the remote object that the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> represents with the specified <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary><returns>The result of the construction request.</returns><param name="ctorMsg">A construction call message that contains the constructor parameters for the new instance of the remote object that is represented by the current <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />. Can be null. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have UnmanagedCode permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public IConstructionReturnMessage InitializeServerObject(IConstructionCallMessage ctorMsg)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected MarshalByRefObject GetUnwrappedServer()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected MarshalByRefObject DetachServer()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attaches the current proxy instance to the specified remote <see cref="T:System.MarshalByRefObject" />.</summary><param name="s">The <see cref="T:System.MarshalByRefObject" /> that the current proxy instance represents. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have UnmanagedCode permission. </exception>
        [SecurityCriticalAttribute()]
        protected void AttachServer(MarshalByRefObject s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the stub data for the specified proxy.</summary><param name="rp">The proxy for which to set stub data. </param><param name="stubData">The new stub data. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have UnmanagedCode permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void SetStubData(RealProxy rp, object stubData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves stub data that is stored for the specified proxy.</summary><returns>Stub data for the specified proxy.</returns><param name="rp">The proxy for which stub data is requested. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have UnmanagedCode permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetStubData(RealProxy rp)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public Type GetProxiedType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, invokes the method that is specified in the provided <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> on the remote object that is represented by the current instance.</summary><returns>The message returned by the invoked method, containing the return value and any out or ref parameters.</returns><param name="msg">A <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> that contains a <see cref="T:System.Collections.IDictionary" /> of information about the method call. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public abstract IMessage Invoke(IMessage msg);
        
        
        /// <summary>Creates an <see cref="T:System.Runtime.Remoting.ObjRef" /> for the specified object type, and registers it with the remoting infrastructure as a client-activated object.</summary><returns>A new instance of <see cref="T:System.Runtime.Remoting.ObjRef" /> that is created for the specified type.</returns><param name="requestedType">The object type that an <see cref="T:System.Runtime.Remoting.ObjRef" /> is created for. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual ObjRef CreateObjRef(Type requestedType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the transparent proxy of the object represented by the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> to the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> into which the transparent proxy is serialized. </param><param name="context">The source and destination of the serialization. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> or <paramref name="context" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have SerializationFormatter permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Requests an unmanaged reference to the object represented by the current proxy instance.</summary><returns>A pointer to a COM Callable Wrapper if the object reference is requested for communication with unmanaged objects in the current process through COM, or a pointer to a cached or newly generated IUnknown COM interface if the object reference is requested for marshaling to a remote location.</returns><param name="fIsMarshalled">true if the object reference is requested for marshaling to a remote location; false if the object reference is requested for communication with unmanaged objects in the current process through COM. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual IntPtr GetCOMIUnknown(bool fIsMarshalled)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Stores an unmanaged proxy of the object that is represented by the current instance.</summary><param name="i">A pointer to the IUnknown interface for the object that is represented by the current proxy instance. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual void SetCOMIUnknown(IntPtr i)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IntPtr SupportsInterface(ref Guid iid)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object GetTransparentProxy()
        {
             throw new NotImplementedException();
        }
        
        
        protected RealProxy()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
