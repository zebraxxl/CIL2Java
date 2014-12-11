using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.SecurityPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets all permission flags comprising the <see cref="T:System.Security.Permissions.SecurityPermission" /> permissions.</summary><returns>One or more of the <see cref="T:System.Security.Permissions.SecurityPermissionFlag" /> values combined using a bitwise OR.</returns><exception cref="T:System.ArgumentException">An attempt is made to set this property to an invalid value. See <see cref="T:System.Security.Permissions.SecurityPermissionFlag" /> for the valid values. </exception>
        public SecurityPermissionFlag Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to assert that all this code's callers have the requisite permission for the operation is declared.</summary><returns>true if permission to assert is declared; otherwise, false.</returns>
        public bool Assertion
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to call unmanaged code is declared.</summary><returns>true if permission to call unmanaged code is declared; otherwise, false.</returns>
        public bool UnmanagedCode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to bypass code verification is declared.</summary><returns>true if permission to bypass code verification is declared; otherwise, false.</returns>
        public bool SkipVerification
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to execute code is declared.</summary><returns>true if permission to execute code is declared; otherwise, false.</returns>
        public bool Execution
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to manipulate threads is declared.</summary><returns>true if permission to manipulate threads is declared; otherwise, false.</returns>
        public bool ControlThread
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to alter or manipulate evidence is declared.</summary><returns>true if the ability to alter or manipulate evidence is declared; otherwise, false.</returns>
        public bool ControlEvidence
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to view and manipulate security policy is declared.</summary><returns>true if permission to manipulate security policy is declared; otherwise, false.</returns>
        public bool ControlPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether code can use a serialization formatter to serialize or deserialize an object.</summary><returns>true if code can use a serialization formatter to serialize or deserialize an object; otherwise, false.</returns>
        public bool SerializationFormatter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to alter or manipulate domain security policy is declared.</summary><returns>true if permission to alter or manipulate security policy in an application domain is declared; otherwise, false.</returns>
        public bool ControlDomainPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to manipulate the current principal is declared.</summary><returns>true if permission to manipulate the current principal is declared; otherwise, false.</returns>
        public bool ControlPrincipal
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether permission to manipulate <see cref="T:System.AppDomain" /> is declared.</summary><returns>true if permission to manipulate <see cref="T:System.AppDomain" /> is declared; otherwise, false.</returns>
        public bool ControlAppDomain
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether code can configure remoting types and channels.</summary><returns>true if code can configure remoting types and channels; otherwise, false.</returns>
        public bool RemotingConfiguration
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether code can plug into the common language runtime infrastructure, such as adding Remoting Context Sinks, Envoy Sinks and Dynamic Sinks.</summary><returns>true if code can plug into the common language runtime infrastructure; otherwise, false.</returns>
        [ComVisibleAttribute(true)]
        public bool Infrastructure
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether code has permission to perform binding redirection in the application configuration file.</summary><returns>true if code can perform binding redirects; otherwise, false.</returns>
        public bool BindingRedirects
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.SecurityPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        public SecurityPermissionAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission CreatePermission()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
