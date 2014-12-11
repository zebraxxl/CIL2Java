using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting;

namespace System
{
    /// <summary>Enables access to objects across application domain boundaries in applications that support remoting.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class MarshalByRefObject
    {
    
    
        /// <summary>Creates a shallow copy of the current <see cref="T:System.MarshalByRefObject" /> object.</summary><returns>A shallow copy of the current <see cref="T:System.MarshalByRefObject" /> object.</returns><param name="cloneIdentity">false to delete the current <see cref="T:System.MarshalByRefObject" /> object's identity, which will cause the object to be assigned a new identity when it is marshaled across a remoting boundary. A value of false is usually appropriate. true to copy the current <see cref="T:System.MarshalByRefObject" /> object's identity to its clone, which will cause remoting client calls to be routed to the remote server object. </param>
        protected MarshalByRefObject MemberwiseClone(bool cloneIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public object GetLifetimeService()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual object InitializeLifetimeService()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.</summary><returns>Information required to generate a proxy.</returns><param name="requestedType">The <see cref="T:System.Type" /> of the object that the new <see cref="T:System.Runtime.Remoting.ObjRef" /> will reference. </param><exception cref="T:System.Runtime.Remoting.RemotingException">This instance is not a valid remoting object. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual ObjRef CreateObjRef(Type requestedType)
        {
             throw new NotImplementedException();
        }
        
        
        protected MarshalByRefObject()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
