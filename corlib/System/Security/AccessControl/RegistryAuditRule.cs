using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents a set of access rights to be audited for a user or group. This class cannot be inherited.</summary>
    public sealed class RegistryAuditRule : AuditRule
    {
        /// <summary>Gets the access rights affected by the audit rule.</summary><returns>A bitwise combination of <see cref="T:System.Security.AccessControl.RegistryRights" /> values that indicates the rights affected by the audit rule.</returns>
        public RegistryRights RegistryRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> class, specifying the user or group to audit, the rights to audit, whether to take inheritance into account, and whether to audit success, failure, or both.</summary><param name="identity">The user or group the rule applies to. Must be of type <see cref="T:System.Security.Principal.SecurityIdentifier" /> or a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="registryRights">A bitwise combination of <see cref="T:System.Security.AccessControl.RegistryRights" /> values specifying the kinds of access to audit.</param><param name="inheritanceFlags">A bitwise combination of <see cref="T:System.Security.AccessControl.InheritanceFlags" /> values specifying whether the audit rule applies to subkeys of the current key.</param><param name="propagationFlags">A bitwise combination of <see cref="T:System.Security.AccessControl.PropagationFlags" /> values that affect the way an inherited audit rule is propagated to subkeys of the current key.</param><param name="flags">A bitwise combination of <see cref="T:System.Security.AccessControl.AuditFlags" /> values specifying whether to audit success, failure, or both.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="eventRights" /> specifies an invalid value.-or-<paramref name="flags" /> specifies an invalid value.-or-<paramref name="inheritanceFlags" /> specifies an invalid value.-or-<paramref name="propagationFlags" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="identity" /> is null. -or-<paramref name="registryRights" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="identity" /> is neither of type <see cref="T:System.Security.Principal.SecurityIdentifier" /> nor of a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
        public RegistryAuditRule(IdentityReference identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> class, specifying the name of the user or group to audit, the rights to audit, whether to take inheritance into account, and whether to audit success, failure, or both.</summary><param name="identity">The name of the user or group the rule applies to.</param><param name="registryRights">A bitwise combination of <see cref="T:System.Security.AccessControl.RegistryRights" /> values specifying the kinds of access to audit.</param><param name="inheritanceFlags">A combination of <see cref="T:System.Security.AccessControl.InheritanceFlags" /> flags that specifies whether the audit rule applies to subkeys of the current key.</param><param name="propagationFlags">A combination of <see cref="T:System.Security.AccessControl.PropagationFlags" /> flags that affect the way an inherited audit rule is propagated to subkeys of the current key.</param><param name="flags">A bitwise combination of <see cref="T:System.Security.AccessControl.AuditFlags" /> values specifying whether to audit success, failure, or both.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="eventRights" /> specifies an invalid value.-or-<paramref name="flags" /> specifies an invalid value.-or-<paramref name="inheritanceFlags" /> specifies an invalid value.-or-<paramref name="propagationFlags" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="registryRights" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="identity" /> is null.-or-<paramref name="identity" /> is a zero-length string.-or-<paramref name="identity" /> is longer than 512 characters.</exception>
        public RegistryAuditRule(string identity, RegistryRights registryRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
