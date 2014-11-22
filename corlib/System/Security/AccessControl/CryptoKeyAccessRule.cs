using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents an access rule for a cryptographic key. An access rule represents a combination of a user's identity, an access mask, and an access control type (allow or deny). An access rule object also contains information about the how the rule is inherited by child objects and how that inheritance is propagated.</summary>
    public sealed class CryptoKeyAccessRule : AccessRule
    {
        /// <summary>Gets the cryptographic key operation to which this access rule controls access.</summary><returns>The cryptographic key operation to which this access rule controls access.</returns>
        public CryptoKeyRights CryptoKeyRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CryptoKeyAccessRule" /> class using the specified values. </summary><param name="identity">The identity to which the access rule applies. This parameter must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="cryptoKeyRights">The cryptographic key operation to which this access rule controls access.</param><param name="type">The valid access control type.</param>
        public CryptoKeyAccessRule(IdentityReference identity, CryptoKeyRights cryptoKeyRights, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CryptoKeyAccessRule" /> class using the specified values.</summary><param name="identity">The identity to which the access rule applies.</param><param name="cryptoKeyRights">The cryptographic key operation to which this access rule controls access.</param><param name="type">The valid access control type.</param>
        public CryptoKeyAccessRule(string identity, CryptoKeyRights cryptoKeyRights, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
