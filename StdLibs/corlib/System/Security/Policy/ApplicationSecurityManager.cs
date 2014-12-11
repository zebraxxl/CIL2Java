using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Security.Policy
{
    /// <summary>Manages trust decisions for manifest-activated applications. </summary>
    [ComVisibleAttribute(true)]
    public static class ApplicationSecurityManager
    {
    
        /// <summary>Gets an application trust collection that contains the cached trust decisions for the user.</summary><returns>An <see cref="T:System.Security.Policy.ApplicationTrustCollection" /> that contains the cached trust decisions for the user.</returns>
        public static ApplicationTrustCollection UserApplicationTrusts
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current application trust manager.</summary><returns>An <see cref="T:System.Security.Policy.IApplicationTrustManager" /> that represents the current trust manager.</returns><exception cref="T:System.Security.Policy.PolicyException">The policy on this application does not have a trust manager.</exception>
        public static IApplicationTrustManager ApplicationTrustManager
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Determines whether the user approves the specified application to execute with the requested permission set.</summary><returns>true to execute the specified application; otherwise, false.</returns><param name="activationContext">An <see cref="T:System.ActivationContext" /> identifying the activation context for the application.</param><param name="context">A <see cref="T:System.Security.Policy.TrustManagerContext" />  identifying the trust manager context for the application.</param><exception cref="T:System.ArgumentNullException">The <paramref name="activationContext" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static bool DetermineApplicationTrust(ActivationContext activationContext, TrustManagerContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
