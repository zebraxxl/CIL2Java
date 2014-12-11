using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents the Windows access control security for a registry key. This class cannot be inherited.</summary>
    public sealed class RegistrySecurity : NativeObjectSecurity
    {
        /// <summary>Gets the enumeration type that the <see cref="T:System.Security.AccessControl.RegistrySecurity" /> class uses to represent access rights.</summary><returns>A <see cref="T:System.Type" /> object representing the <see cref="T:System.Security.AccessControl.RegistryRights" /> enumeration.</returns>
        public override Type AccessRightType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type that the <see cref="T:System.Security.AccessControl.RegistrySecurity" /> class uses to represent access rules.</summary><returns>A <see cref="T:System.Type" /> object representing the <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> class.</returns>
        public override Type AccessRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type that the <see cref="T:System.Security.AccessControl.RegistrySecurity" /> class uses to represent audit rules.</summary><returns>A <see cref="T:System.Type" /> object representing the <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> class.</returns>
        public override Type AuditRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RegistrySecurity()
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new access control rule for the specified user, with the specified access rights, access control, and flags.</summary><returns>A <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> object representing the specified rights for the specified user.</returns><param name="identityReference">An <see cref="T:System.Security.Principal.IdentityReference" /> that identifies the user or group the rule applies to.</param><param name="accessMask">A bitwise combination of <see cref="T:System.Security.AccessControl.RegistryRights" /> values specifying the access rights to allow or deny, cast to an integer.</param><param name="isInherited">A Boolean value specifying whether the rule is inherited.</param><param name="inheritanceFlags">A bitwise combination of <see cref="T:System.Security.AccessControl.InheritanceFlags" /> values specifying how the rule is inherited by subkeys.</param><param name="propagationFlags">A bitwise combination of <see cref="T:System.Security.AccessControl.PropagationFlags" /> values that modify the way the rule is inherited by subkeys. Meaningless if the value of <paramref name="inheritanceFlags" /> is <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="type">One of the <see cref="T:System.Security.AccessControl.AccessControlType" /> values specifying whether the rights are allowed or denied.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" />, or <paramref name="type" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="identityReference" /> is null. -or-<paramref name="accessMask" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="identityReference" /> is neither of type <see cref="T:System.Security.Principal.SecurityIdentifier" />, nor of a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new audit rule, specifying the user the rule applies to, the access rights to audit, the inheritance and propagation of the rule, and the outcome that triggers the rule.</summary><returns>A <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> object representing the specified audit rule for the specified user, with the specified flags. The return type of the method is the base class, <see cref="T:System.Security.AccessControl.AuditRule" />, but the return value can be cast safely to the derived class.</returns><param name="identityReference">An <see cref="T:System.Security.Principal.IdentityReference" /> that identifies the user or group the rule applies to.</param><param name="accessMask">A bitwise combination of <see cref="T:System.Security.AccessControl.RegistryRights" /> values specifying the access rights to audit, cast to an integer.</param><param name="isInherited">A Boolean value specifying whether the rule is inherited.</param><param name="inheritanceFlags">A bitwise combination of <see cref="T:System.Security.AccessControl.InheritanceFlags" /> values specifying how the rule is inherited by subkeys.</param><param name="propagationFlags">A bitwise combination of <see cref="T:System.Security.AccessControl.PropagationFlags" /> values that modify the way the rule is inherited by subkeys. Meaningless if the value of <paramref name="inheritanceFlags" /> is <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="flags">A bitwise combination of <see cref="T:System.Security.AccessControl.AuditFlags" /> values specifying whether to audit successful access, failed access, or both.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" />, or <paramref name="flags" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="identityReference" /> is null. -or-<paramref name="accessMask" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="identityReference" /> is neither of type <see cref="T:System.Security.Principal.SecurityIdentifier" />, nor of a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for a matching access control with which the new rule can be merged. If none are found, adds the new rule.</summary><param name="rule">The access control rule to add.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void AddAccessRule(RegistryAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access control rules with the same user and <see cref="T:System.Security.AccessControl.AccessControlType" /> (allow or deny) as the specified rule, and then adds the specified rule.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> to add. The user and <see cref="T:System.Security.AccessControl.AccessControlType" /> of this rule determine the rules to remove before this rule is added.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void SetAccessRule(RegistryAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access control rules with the same user as the specified rule, regardless of <see cref="T:System.Security.AccessControl.AccessControlType" />, and then adds the specified rule.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> to add. The user specified by this rule determines the rules to remove before this rule is added.</param>
        public void ResetAccessRule(RegistryAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an access control rule with the same user and <see cref="T:System.Security.AccessControl.AccessControlType" /> (allow or deny) as the specified access rule, and with compatible inheritance and propagation flags; if such a rule is found, the rights contained in the specified access rule are removed from it.</summary><returns>true if a compatible rule is found; otherwise false.</returns><param name="rule">A <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> that specifies the user and <see cref="T:System.Security.AccessControl.AccessControlType" /> to search for, and a set of inheritance and propagation flags that a matching rule, if found, must be compatible with. Specifies the rights to remove from the compatible rule, if found.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public bool RemoveAccessRule(RegistryAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for all access control rules with the same user and <see cref="T:System.Security.AccessControl.AccessControlType" /> (allow or deny) as the specified rule and, if found, removes them.</summary><param name="rule">A <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> that specifies the user and <see cref="T:System.Security.AccessControl.AccessControlType" /> to search for. Any rights, inheritance flags, or propagation flags specified by this rule are ignored.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAccessRuleAll(RegistryAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an access control rule that exactly matches the specified rule and, if found, removes it.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> to remove.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAccessRuleSpecific(RegistryAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an audit rule with which the new rule can be merged. If none are found, adds the new rule.</summary><param name="rule">The audit rule to add. The user specified by this rule determines the search.</param>
        public void AddAuditRule(RegistryAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules with the same user as the specified rule, regardless of the <see cref="T:System.Security.AccessControl.AuditFlags" /> value, and then adds the specified rule.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> to add. The user specified by this rule determines the rules to remove before this rule is added.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void SetAuditRule(RegistryAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an audit control rule with the same user as the specified rule, and with compatible inheritance and propagation flags; if a compatible rule is found, the rights contained in the specified rule are removed from it.</summary><returns>true if a compatible rule is found; otherwise, false.</returns><param name="rule">A <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> that specifies the user to search for, and a set of inheritance and propagation flags that a matching rule, if found, must be compatible with. Specifies the rights to remove from the compatible rule, if found.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public bool RemoveAuditRule(RegistryAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for all audit rules with the same user as the specified rule and, if found, removes them.</summary><param name="rule">A <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> that specifies the user to search for. Any rights, inheritance flags, or propagation flags specified by this rule are ignored.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAuditRuleAll(RegistryAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an audit rule that exactly matches the specified rule and, if found, removes it.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.RegistryAuditRule" /> to be removed.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAuditRuleSpecific(RegistryAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
