using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Deployment.Internal
{
    /// <summary>Provides access to internal properties of an <see cref="T:System.ApplicationIdentity" /> object.</summary>
    [ComVisibleAttribute(false)]
    public static class InternalApplicationIdentityHelper
    {
        /// <summary>Gets an IDefinitionAppId Interface representing the unique identifier of an <see cref="T:System.ApplicationIdentity" /> object.</summary><returns>The unique identifier held by the <see cref="T:System.ApplicationIdentity" /> object.</returns><param name="id">The object from which to extract the identifier.</param>
        [SecurityCriticalAttribute()]
        public static object GetInternalAppId(ApplicationIdentity id)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
