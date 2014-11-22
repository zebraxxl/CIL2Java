using System.Runtime.InteropServices;

namespace System.Security.Principal
{
    /// <summary>Defines the basic functionality of an identity object.</summary>
    [ComVisibleAttribute(true)]
    public interface IIdentity
    {
        /// <summary>Gets the name of the current user.</summary><returns>The name of the user on whose behalf the code is running.</returns>
        string Name
        {
            get;
        }
    
        /// <summary>Gets the type of authentication used.</summary><returns>The type of authentication used to identify the user.</returns>
        string AuthenticationType
        {
            get;
        }
    
        /// <summary>Gets a value that indicates whether the user has been authenticated.</summary><returns>true if the user was authenticated; otherwise, false.</returns>
        bool IsAuthenticated
        {
            get;
        }
    
    
    }
}
