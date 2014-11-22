using System.Runtime.InteropServices;
using System;

namespace System.Security.Principal
{
    /// <summary>Specifies how principal and identity objects should be created for an application domain. The default is UnauthenticatedPrincipal.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum PrincipalPolicy : int
    {
        /// <summary>Principal and identity objects for the unauthenticated entity should be created. An unauthenticated entity has <see cref="P:System.Security.Principal.GenericIdentity.Name" /> set to the empty string ("") and <see cref="P:System.Security.Principal.GenericIdentity.IsAuthenticated" /> set to false.</summary>
        UnauthenticatedPrincipal = 0,
        /// <summary>No principal or identity objects should be created.</summary>
        NoPrincipal = 1,
        /// <summary>Principal and identity objects that reflect the operating system token associated with the current execution thread should be created, and the associated operating system groups should be mapped into roles.</summary>
        WindowsPrincipal = 2
    }
}
