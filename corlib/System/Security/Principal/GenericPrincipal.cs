using System.Runtime.InteropServices;
using System.Security.Claims;

namespace System.Security.Principal
{
    /// <summary>Represents a generic principal.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class GenericPrincipal : ClaimsPrincipal
    {
    
        /// <summary>Gets the <see cref="T:System.Security.Principal.GenericIdentity" /> of the user represented by the current <see cref="T:System.Security.Principal.GenericPrincipal" />.</summary><returns>The <see cref="T:System.Security.Principal.GenericIdentity" /> of the user represented by the <see cref="T:System.Security.Principal.GenericPrincipal" />.</returns>
        public override IIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.GenericPrincipal" /> class from a user identity and an array of role names to which the user represented by that identity belongs.</summary><param name="identity">A basic implementation of <see cref="T:System.Security.Principal.IIdentity" /> that represents any user. </param><param name="roles">An array of role names to which the user represented by the <paramref name="identity" /> parameter belongs. </param><exception cref="T:System.ArgumentNullException">The <paramref name="identity" /> parameter is null. </exception>
        public GenericPrincipal(IIdentity identity, string[] roles)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.Security.Principal.GenericPrincipal" /> belongs to the specified role.</summary><returns>true if the current <see cref="T:System.Security.Principal.GenericPrincipal" /> is a member of the specified role; otherwise, false.</returns><param name="role">The name of the role for which to check membership. </param>
        public override bool IsInRole(string role)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
