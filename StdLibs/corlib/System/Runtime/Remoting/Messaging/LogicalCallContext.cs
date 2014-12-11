using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization;
using System;
using System.Collections;
using System.Security.Principal;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Provides a set of properties that are carried with the execution code path during remote method calls.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public sealed class LogicalCallContext : ISerializable, ICloneable
    {
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> contains information.</summary><returns>A Boolean value indicating whether the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> contains information.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public bool HasInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Populates a specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" />.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param><param name="context">The contextual information about the source or destination of the serialization. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have SerializationFormatter permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Empties a data slot with the specified name.</summary><param name="name">The name of the data slot to empty. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void FreeNamedDataSlot(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an object associated with the specified name from the current instance.</summary><returns>The object in the logical call context associated with the specified name.</returns><param name="name">The name of the item in the call context. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public object GetData(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Stores the specified object in the current instance, and associates it with the specified name.</summary><param name="name">The name with which to associate the new item in the call context. </param><param name="data">The object to store in the call context. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public void SetData(string name, object data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
