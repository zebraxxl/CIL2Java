using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Security.Policy
{
    /// <summary>Determines whether an application should be executed and which set of permissions should be granted to it.</summary>
    [ComVisibleAttribute(true)]
    public interface IApplicationTrustManager : ISecurityEncodable
    {
        /// <summary>Determines whether an application should be executed and which set of permissions should be granted to it.</summary><returns>An object that contains security decisions about the application.</returns><param name="activationContext">The activation context for the application.</param><param name="context">The trust manager context for the application.</param>
        ApplicationTrust DetermineApplicationTrust(ActivationContext activationContext, TrustManagerContext context);
        
        
    }
}
