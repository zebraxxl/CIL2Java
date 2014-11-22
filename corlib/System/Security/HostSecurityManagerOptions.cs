using System.Runtime.InteropServices;
using System;

namespace System.Security
{
    /// <summary>Specifies the security policy components to be used by the host security manager.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum HostSecurityManagerOptions : int
    {
        /// <summary>Use none of the security policy components.</summary>
        None = 0,
        /// <summary>Use the application domain evidence.</summary>
        HostAppDomainEvidence = 1,
        /// <summary>Use the policy level specified in the <see cref="P:System.Security.HostSecurityManager.DomainPolicy" /> property.</summary>
        HostPolicyLevel = 2,
        /// <summary>Use the assembly evidence.</summary>
        HostAssemblyEvidence = 4,
        /// <summary>Route calls to the <see cref="M:System.Security.Policy.ApplicationSecurityManager.DetermineApplicationTrust(System.ActivationContext,System.Security.Policy.TrustManagerContext)" /> method to the <see cref="M:System.Security.HostSecurityManager.DetermineApplicationTrust(System.Security.Policy.Evidence,System.Security.Policy.Evidence,System.Security.Policy.TrustManagerContext)" /> method first.</summary>
        HostDetermineApplicationTrust = 8,
        /// <summary>Use the <see cref="M:System.Security.HostSecurityManager.ResolvePolicy(System.Security.Policy.Evidence)" /> method to resolve the application evidence.</summary>
        HostResolvePolicy = 16,
        /// <summary>Use all security policy components.</summary>
        AllFlags = 31
    }
}
