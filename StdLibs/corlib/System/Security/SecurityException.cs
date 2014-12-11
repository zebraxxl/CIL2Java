using System.Runtime.InteropServices;
using System;
using System.Security.Permissions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace System.Security
{
    /// <summary>The exception that is thrown when a security error is detected.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SecurityException : SystemException
    {
    
        /// <summary>Gets or sets the security action that caused the exception.</summary><returns>One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values.</returns>
        [ComVisibleAttribute(false)]
        public SecurityAction Action
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the type of the permission that failed.</summary><returns>The type of the permission that failed.</returns>
        public Type PermissionType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the first permission in a permission set or permission set collection that failed the demand.</summary><returns>An <see cref="T:System.Security.IPermission" /> object representing the first permission that failed.</returns>
        public IPermission FirstPermissionThatFailed
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the state of the permission that threw the exception.</summary><returns>The state of the permission at the time the exception was thrown.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        public string PermissionState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the demanded security permission, permission set, or permission set collection that failed.</summary><returns>A permission, permission set, or permission set collection object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public object Demanded
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the granted permission set of the assembly that caused the <see cref="T:System.Security.SecurityException" />.</summary><returns>The XML representation of the granted set of the assembly.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        public string GrantedSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the refused permission set of the assembly that caused the <see cref="T:System.Security.SecurityException" />.</summary><returns>The XML representation of the refused permission set of the assembly.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        public string RefusedSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the denied security permission, permission set, or permission set collection that caused a demand to fail.</summary><returns>A permission, permission set, or permission set collection object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public object DenySetInstance
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the permission, permission set, or permission set collection that is part of the permit-only stack frame that caused a security check to fail.</summary><returns>A permission, permission set, or permission set collection object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public object PermitOnlySetInstance
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets information about the failed assembly.</summary><returns>An <see cref="T:System.Reflection.AssemblyName" /> that identifies the failed assembly.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public AssemblyName FailedAssemblyInfo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the information about the method associated with the exception.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object describing the method.</returns><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public MethodInfo Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the zone of the assembly that caused the exception.</summary><returns>One of the <see cref="T:System.Security.SecurityZone" /> values that identifies the zone of the assembly that caused the exception.</returns>
        public SecurityZone Zone
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the URL of the assembly that caused the exception.</summary><returns>A URL that identifies the location of the assembly.</returns>
        public string Url
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SecurityException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message.</summary><param name="message">The error message that explains the reason for the exception. </param>
        public SecurityException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message and the permission type that caused the exception to be thrown.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="type">The type of the permission that caused the exception to be thrown. </param>
        [SecuritySafeCriticalAttribute()]
        public SecurityException(string message, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message, the permission type that caused the exception to be thrown, and the permission state.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="type">The type of the permission that caused the exception to be thrown. </param><param name="state">The state of the permission that caused the exception to be thrown. </param>
        [SecuritySafeCriticalAttribute()]
        public SecurityException(string message, Type type, string state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public SecurityException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException"><paramref name="info " />is null.</exception>
        [SecuritySafeCriticalAttribute()]
        protected SecurityException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class for an exception caused by an insufficient grant set. </summary><param name="message">The error message that explains the reason for the exception.</param><param name="assemblyName">An <see cref="T:System.Reflection.AssemblyName" /> that specifies the name of the assembly that caused the exception.</param><param name="grant">A <see cref="T:System.Security.PermissionSet" /> that represents the permissions granted the assembly.</param><param name="refused">A <see cref="T:System.Security.PermissionSet" /> that represents the refused permission or permission set.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that represents the method that encountered the exception.</param><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values.</param><param name="demanded">The demanded permission, permission set, or permission set collection.</param><param name="permThatFailed">An <see cref="T:System.Security.IPermission" /> that represents the permission that failed.</param><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> for the assembly that caused the exception.</param>
        [SecuritySafeCriticalAttribute()]
        public SecurityException(string message, AssemblyName assemblyName, PermissionSet grant, PermissionSet refused, MethodInfo method, SecurityAction action, object demanded, IPermission permThatFailed, Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class for an exception caused by a Deny on the stack.  </summary><param name="message">The error message that explains the reason for the exception.</param><param name="deny">The denied permission or permission set.</param><param name="permitOnly">The permit-only permission or permission set.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo" /> that identifies the method that encountered the exception.</param><param name="demanded">The demanded permission, permission set, or permission set collection.</param><param name="permThatFailed">An <see cref="T:System.Security.IPermission" /> that identifies the permission that failed.</param>
        [SecuritySafeCriticalAttribute()]
        public SecurityException(string message, object deny, object permitOnly, MethodInfo method, object demanded, IPermission permThatFailed)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the <see cref="T:System.Security.SecurityException" />.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
