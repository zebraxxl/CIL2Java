using System.Runtime.InteropServices;
using System;
using System.Security.Permissions;
using System.Runtime.Serialization;

namespace System.Security
{
    /// <summary>The exception that is thrown when a denied host resource is detected.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class HostProtectionException : SystemException
    {
    
        /// <summary>Gets or sets the host protection resources that are inaccessible to partially trusted code.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.HostProtectionResource" /> values identifying the inaccessible host protection categories. The default is <see cref="F:System.Security.Permissions.HostProtectionResource.None" />.</returns>
        public HostProtectionResource ProtectedResources
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the demanded host protection resources that caused the exception to be thrown.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.HostProtectionResource" /> values identifying the protection resources causing the exception to be thrown. The default is <see cref="F:System.Security.Permissions.HostProtectionResource.None" />. </returns>
        public HostProtectionResource DemandedResources
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HostProtectionException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.HostProtectionException" /> class with a specified error message. </summary><param name="message">The message that describes the error.</param>
        public HostProtectionException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.HostProtectionException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception. </summary><param name="message">The error message that explains the reason for the exception. </param><param name="e">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public HostProtectionException(string message, Exception e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.HostProtectionException" /> class using the provided serialization information and streaming context.</summary><param name="info">The object that holds the serialized object data.</param><param name="context">Contextual information about the source or destination.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        protected HostProtectionException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.HostProtectionException" /> class with a specified error message, the protected host resources, and the host resources that caused the exception to be thrown.</summary><param name="message">The error message that explains the reason for the exception.</param><param name="protectedResources">A bitwise combination of the enumeration values that specify the host resources that are inaccessible to partially trusted code.</param><param name="demandedResources">A bitwise combination of the enumeration values that specify the demanded host resources.</param>
        public HostProtectionException(string message, HostProtectionResource protectedResources, HostProtectionResource demandedResources)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with information about the host protection exception.</summary><param name="info">The serialized object data about the exception being thrown.</param><param name="context">The contextual information about the source or destination.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
