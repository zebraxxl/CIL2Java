using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Collections.Generic;
using System.Security;

namespace System.Security.Principal
{
    /// <summary>Represents a generic user.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class GenericIdentity : ClaimsIdentity
    {
    
        /// <summary>Gets all claims for the user represented by this generic identity.</summary><returns>A collection of claims for this <see cref="T:System.Security.Principal.GenericIdentity" /> object.</returns>
        public override IEnumerable<Claim> Claims
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the user's name.</summary><returns>The name of the user on whose behalf the code is being run.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of authentication used to identify the user.</summary><returns>The type of authentication used to identify the user.</returns>
        public override string AuthenticationType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the user has been authenticated.</summary><returns>true if the user was has been authenticated; otherwise, false.</returns>
        public override bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.GenericIdentity" /> class representing the user with the specified name.</summary><param name="name">The name of the user on whose behalf the code is running. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public GenericIdentity(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.GenericIdentity" /> class representing the user with the specified name and authentication type.</summary><param name="name">The name of the user on whose behalf the code is running. </param><param name="type">The type of authentication used to identify the user. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null.-or- The <paramref name="type" /> parameter is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public GenericIdentity(string name, string type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.GenericIdentity" /> class by using the specified <see cref="T:System.Security.Principal.GenericIdentity" /> object.</summary><param name="identity">The object from which to construct the new instance of <see cref="T:System.Security.Principal.GenericIdentity" />.</param>
        protected GenericIdentity(GenericIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        public override ClaimsIdentity Clone()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
