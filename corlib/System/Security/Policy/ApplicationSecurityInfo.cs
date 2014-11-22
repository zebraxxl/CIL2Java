using System.Security;
using System.Runtime.InteropServices;
using System;

namespace System.Security.Policy
{
    /// <summary>Holds the security evidence for an application. This class cannot be inherited.</summary>
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public sealed class ApplicationSecurityInfo
    {
    
        /// <summary>Gets or sets the application identity information.</summary><returns>An <see cref="T:System.ApplicationId" /> object.</returns><exception cref="T:System.ArgumentNullException"><see cref="P:System.Security.Policy.ApplicationSecurityInfo.ApplicationId" /> is set to null.</exception>
        public ApplicationId ApplicationId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the top element in the application, which is described in the deployment identity.</summary><returns>An <see cref="T:System.ApplicationId" /> object describing the top element of the application.</returns><exception cref="T:System.ArgumentNullException"><see cref="P:System.Security.Policy.ApplicationSecurityInfo.DeploymentId" /> is set to null. </exception>
        public ApplicationId DeploymentId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the default permission set.</summary><returns>A <see cref="T:System.Security.PermissionSet" /> object representing the default permissions for the application. The default is a <see cref="T:System.Security.PermissionSet" /> with a permission state of <see cref="F:System.Security.Permissions.PermissionState.None" /></returns><exception cref="T:System.ArgumentNullException"><see cref="P:System.Security.Policy.ApplicationSecurityInfo.DefaultRequestSet" /> is set to null. </exception>
        public PermissionSet DefaultRequestSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the evidence for the application.</summary><returns>An <see cref="T:System.Security.Policy.Evidence" /> object for the application.</returns><exception cref="T:System.ArgumentNullException"><see cref="P:System.Security.Policy.ApplicationSecurityInfo.ApplicationEvidence" /> is set to null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public Evidence ApplicationEvidence
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.ApplicationSecurityInfo" /> class using the provided activation context. </summary><param name="activationContext">An <see cref="T:System.ActivationContext" /> object that uniquely identifies the target application.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationContext" /> is null. </exception>
        public ApplicationSecurityInfo(ActivationContext activationContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
