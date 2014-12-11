using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Security.AccessControl
{
    /// <summary>The exception that is thrown when a method in the <see cref="N:System.Security.AccessControl" /> namespace attempts to enable a privilege that it does not have.</summary>
    [Serializable]
    public sealed class PrivilegeNotHeldException : UnauthorizedAccessException, ISerializable
    {
    
        /// <summary>Gets the name of the privilege that is not enabled.</summary><returns>The name of the privilege that the method failed to enable.</returns>
        public string PrivilegeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PrivilegeNotHeldException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.PrivilegeNotHeldException" /> class by using the specified privilege.</summary><param name="privilege">The privilege that is not enabled.</param>
        public PrivilegeNotHeldException(string privilege)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.PrivilegeNotHeldException" /> class by using the specified exception.</summary><param name="privilege">The privilege that is not enabled.</param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.</param>
        public PrivilegeNotHeldException(string privilege, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <paramref name="info" /> parameter with information about the exception.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
