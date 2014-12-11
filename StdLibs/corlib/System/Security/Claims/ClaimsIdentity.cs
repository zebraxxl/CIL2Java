using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security;
using System;

namespace System.Security.Claims
{
    /// <summary>Represents a claims-based identity.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ClaimsIdentity : IIdentity
    {
        /// <summary>The default issuer; “LOCAL AUTHORITY”.</summary>
        public const string DefaultIssuer = "LOCAL AUTHORITY";
        /// <summary>The default name claim type; <see cref="F:System.Security.Claims.ClaimTypes.Name" />.</summary>
        public const string DefaultNameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
        /// <summary>The default role claim type; <see cref="F:System.Security.Claims.ClaimTypes.Role" />.</summary>
        public const string DefaultRoleClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";
    
        /// <summary>Gets the authentication type.</summary><returns>The authentication type.</returns>
        public virtual string AuthenticationType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the identity has been authenticated.</summary><returns>true if the identity has been authenticated; otherwise, false.</returns>
        public virtual bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the identity of the calling party that was granted delegation rights.</summary><returns>The calling party that was granted delegation rights.</returns><exception cref="T:System.InvalidOperationException">An attempt to set the property to the current instance occurs.</exception>
        public ClaimsIdentity Actor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the token that was used to create this claims identity.</summary><returns>The bootstrap context.</returns>
        public object BootstrapContext
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the claims associated with this claims identity.</summary><returns>The collection of claims associated with this claims identity.</returns>
        public virtual IEnumerable<Claim> Claims
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the label for this claims identity.</summary><returns>The label.</returns>
        public string Label
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of this claims identity.</summary><returns>The name or null.</returns>
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the claim type that is used to determine which claims provide the value for the <see cref="P:System.Security.Claims.ClaimsIdentity.Name" /> property of this claims identity.</summary><returns>The name claim type.</returns>
        public string NameClaimType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the claim type that will be interpreted as a .NET Framework role among the claims in this claims identity.</summary><returns>The role claim type.</returns>
        public string RoleClaimType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ClaimsIdentity()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class using the name and authentication type from the specified <see cref="T:System.Security.Principal.IIdentity" />.</summary><param name="identity">The identity from which to base the new claims identity.</param>
        public ClaimsIdentity(IIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        public ClaimsIdentity(IEnumerable<Claim> claims)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class with an empty claims collection and the specified authentication type.</summary><param name="authenticationType">The type of authentication used.</param>
        public ClaimsIdentity(string authenticationType)
        {
             throw new NotImplementedException();
        }
        
        
        public ClaimsIdentity(IEnumerable<Claim> claims, string authenticationType)
        {
             throw new NotImplementedException();
        }
        
        
        public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class with the specified authentication type, name claim type, and role claim type.</summary><param name="authenticationType">The type of authentication used.</param><param name="nameType">The claim type to use for name claims.</param><param name="roleType">The claim type to use for role claims.</param>
        public ClaimsIdentity(string authenticationType, string nameType, string roleType)
        {
             throw new NotImplementedException();
        }
        
        
        public ClaimsIdentity(IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
        {
             throw new NotImplementedException();
        }
        
        
        public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class from a serialized stream created by using <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary><param name="info">The serialized data.</param><param name="context">The context for serialization.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        [SecurityCriticalAttribute()]
        protected ClaimsIdentity(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.ClaimsIdentity" /> class from a serialized stream created by using <see cref="T:System.Runtime.Serialization.ISerializable" />.</summary><param name="info">The serialized data.</param>
        [SecurityCriticalAttribute()]
        protected ClaimsIdentity(SerializationInfo info)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ClaimsIdentity Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a single claim to this claims identity.</summary><param name="claim">The claim to add.</param><exception cref="T:System.ArgumentNullException"><paramref name="claim" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public virtual void AddClaim(Claim claim)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual void AddClaims(IEnumerable<Claim> claims)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts to remove a claim from the claims identity.</summary><returns>true if the claim was successfully removed; otherwise, false.</returns><param name="claim">The claim to remove.</param>
        [SecurityCriticalAttribute()]
        public virtual bool TryRemoveClaim(Claim claim)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Attempts to remove a claim from the claims identity.</summary><param name="claim">The claim to remove.</param><exception cref="T:System.InvalidOperationException">The claim cannot be removed.</exception>
        [SecurityCriticalAttribute()]
        public virtual void RemoveClaim(Claim claim)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerable<Claim> FindAll(Predicate<Claim> match)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves all of the claims that have the specified claim type.</summary><returns>The matching claims. The list is read-only.</returns><param name="type">The claim type against which to match claims.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.</exception>
        public virtual IEnumerable<Claim> FindAll(string type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool HasClaim(Predicate<Claim> match)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether this claims identity has a claim with the specified claim type and value.</summary><returns>true if a match is found; otherwise, false.</returns><param name="type">The type of the claim to match.</param><param name="value">The value of the claim to match.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.-or-<paramref name="value" /> is null.</exception>
        public virtual bool HasClaim(string type, string value)
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
        
        
        /// <summary>Populates the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with data needed to serialize the current <see cref="T:System.Security.Claims.ClaimsIdentity" /> object.</summary><param name="info">The object to populate with data.</param><param name="context">The destination for this serialization. Can be null.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        [SecurityCriticalAttribute()]
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
