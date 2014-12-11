using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Defines the method that creates a new identity permission.</summary>
    [ComVisibleAttribute(true)]
    public interface IIdentityPermissionFactory
    {
        /// <summary>Creates a new identity permission for the specified evidence.</summary><returns>The new identity permission.</returns><param name="evidence">The evidence from which to create the new identity permission. </param>
        IPermission CreateIdentityPermission(Evidence evidence);
        
        
    }
}
