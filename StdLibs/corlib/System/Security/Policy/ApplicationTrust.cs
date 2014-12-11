using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Collections.Generic;

namespace System.Security.Policy
{
    /// <summary>Encapsulates security decisions about an application. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ApplicationTrust : EvidenceBase, ISecurityEncodable
    {
    
        /// <summary>Gets or sets the application identity for the application trust object.</summary><returns>An <see cref="T:System.ApplicationIdentity" /> for the application trust object.</returns><exception cref="T:System.ArgumentNullException"><see cref="T:System.ApplicationIdentity" /> cannot be set because it has a value of null.</exception>
        public ApplicationIdentity ApplicationIdentity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the policy statement defining the default grant set.</summary><returns>A <see cref="T:System.Security.Policy.PolicyStatement" /> describing the default grants.</returns>
        public PolicyStatement DefaultGrantSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of full-trust assemblies for this application trust.</summary><returns>A list of full-trust assemblies.</returns>
        public IList<StrongName> FullTrustAssemblies
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the application has the required permission grants and is trusted to run.</summary><returns>true if the application is trusted to run; otherwise, false. The default is false.</returns>
        public bool IsApplicationTrustedToRun
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether application trust information is persisted.</summary><returns>true if application trust information is persisted; otherwise, false. The default is false.</returns>
        public bool Persist
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets extra security information about the application.</summary><returns>An object containing additional security information about the application.</returns><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public object ExtraInfo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.ApplicationTrust" /> class with an <see cref="T:System.ApplicationIdentity" />. </summary><param name="applicationIdentity">An <see cref="T:System.ApplicationIdentity" /> that uniquely identifies an application.</param>
        public ApplicationTrust(ApplicationIdentity applicationIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        public ApplicationTrust()
        {
             throw new NotImplementedException();
        }
        
        
        public ApplicationTrust(PermissionSet defaultGrantSet, IEnumerable<StrongName> fullTrustAssemblies)
        {
             throw new NotImplementedException();
        }
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs an <see cref="T:System.Security.Policy.ApplicationTrust" /> object with a given state from an XML encoding.</summary><param name="element">The XML encoding to use to reconstruct the <see cref="T:System.Security.Policy.ApplicationTrust" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><exception cref="T:System.ArgumentException">The XML encoding used for <paramref name="element" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" /></PermissionSet>
        public void FromXml(SecurityElement element)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
