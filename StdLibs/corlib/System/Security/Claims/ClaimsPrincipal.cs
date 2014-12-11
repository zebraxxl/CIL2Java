using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Security;

namespace System.Security.Claims
{
    /// <summary>An <see cref="T:System.Security.Principal.IPrincipal" /> implementation that supports multiple claims-based identities.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ClaimsPrincipal : IPrincipal
    {
    
        /// <summary>Gets and sets the delegate used to select the claims identity returned by the <see cref="P:System.Security.Claims.ClaimsPrincipal.Identity" /> property.</summary><returns>The delegate. The default is null.</returns>
        public static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> PrimaryIdentitySelector
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets and sets the delegate used to select the claims principal returned by the <see cref="P:System.Security.Claims.ClaimsPrincipal.Current" /> property.</summary><returns>The delegate. The default is null.</returns>
        public static Func<ClaimsPrincipal> ClaimsPrincipalSelector
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection that contains all of the claims from all of the claims identities associated with this claims principal.</summary><returns>The claims associated with this principal.</returns>
        public virtual IEnumerable<Claim> Claims
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current claims principal.</summary><returns>The current claims principal.</returns>
        public static ClaimsPrincipal Current
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection that contains all of the claims identities associated with this claims principal.</summary><returns>The collection of claims identities.</returns>
        public virtual IEnumerable<ClaimsIdentity> Identities
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the primary claims identity associated with this claims principal.</summary><returns>The primary claims identity associated with this claims principal.</returns>
        public virtual IIdentity Identity
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ClaimsPrincipal()
        {
             throw new NotImplementedException();
        }
        
        
        public ClaimsPrincipal(IEnumerable<ClaimsIdentity> identities)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> class from the specified identity.</summary><param name="identity">The identity from which to initialize the new claims principal.</param><exception cref="T:System.ArgumentNullException"><paramref name="identity" /> is null.</exception>
        public ClaimsPrincipal(IIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> class from the specified principal.</summary><param name="principal">The principal from which to initialize the new claims principal.</param><exception cref="T:System.ArgumentNullException"><paramref name="principal" /> is null.</exception>
        public ClaimsPrincipal(IPrincipal principal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> class from a serialized stream created by using <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary><param name="info">The serialized data.</param><param name="context">The context for serialization.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        [SecurityCriticalAttribute()]
        protected ClaimsPrincipal(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with data needed to serialize the current <see cref="T:System.Security.Claims.ClaimsPrincipal" /> object.</summary><param name="info">The object to populate with data.</param><param name="context">The destination for this serialization. Can be null.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        [SecurityCriticalAttribute()]
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified claims identity to this claims principal.</summary><param name="identity">The claims identity to add.</param><exception cref="T:System.ArgumentNullException"><paramref name="identity" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public virtual void AddIdentity(ClaimsIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual void AddIdentities(IEnumerable<ClaimsIdentity> identities)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerable<Claim> FindAll(Predicate<Claim> match)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves all or the claims that have the specified claim type.</summary><returns>The matching claims.</returns><param name="type">The claim type against which to match claims.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.</exception>
        public virtual IEnumerable<Claim> FindAll(string type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Claim FindFirst(Predicate<Claim> match)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the first claim with the specified claim type.</summary><returns>The first matching claim or null if no match is found.</returns><param name="type">The claim type to match.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.</exception>
        public virtual Claim FindFirst(string type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool HasClaim(Predicate<Claim> match)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any of the claims identities associated with this claims principal contains a claim with the specified claim type and value.</summary><returns>true if a matching claim exists; otherwise, false.</returns><param name="type">The type of the claim to match.</param><param name="value">The value of the claim to match.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or-<paramref name="value" /> is null.</exception>
        public virtual bool HasClaim(string type, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the entity (user) represented by this claims principal is in the specified role.</summary><returns>true if claims principal is in the specified role; otherwise, false.</returns><param name="role">The role for which to check.</param>
        public virtual bool IsInRole(string role)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
