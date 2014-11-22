using System.Runtime.InteropServices;

namespace System.Security.Principal
{
    /// <summary>Defines the basic functionality of a principal object.</summary>
    [ComVisibleAttribute(true)]
    public interface IPrincipal
    {
        /// <summary>Gets the identity of the current principal.</summary><returns>The <see cref="T:System.Security.Principal.IIdentity" /> object associated with the current principal.</returns>
        IIdentity Identity
        {
            get;
        }
    
    
        /// <summary>Determines whether the current principal belongs to the specified role.</summary><returns>true if the current principal is a member of the specified role; otherwise, false.</returns><param name="role">The name of the role for which to check membership. </param>
        bool IsInRole(string role);
        
        
    }
}
