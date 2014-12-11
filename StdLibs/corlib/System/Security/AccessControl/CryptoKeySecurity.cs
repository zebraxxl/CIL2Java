using System;
using System.Security;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Provides the ability to control access to a cryptographic key object without direct manipulation of  an Access Control List (ACL).</summary>
    public sealed class CryptoKeySecurity : NativeObjectSecurity
    {
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the securable object associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><returns>The type of the securable object associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</returns>
        public override Type AccessRightType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the object associated with the access rules of this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object. The <see cref="T:System.Type" /> object must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>The type of the object associated with the access rules of this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</returns>
        public override Type AccessRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> object associated with the audit rules of this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object. The <see cref="T:System.Type" /> object must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>The type of the object associated with the audit rules of this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</returns>
        public override Type AuditRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CryptoKeySecurity()
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> class by using the specified security descriptor.</summary><param name="securityDescriptor">The security descriptor from which to create the new <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</param>
        [SecuritySafeCriticalAttribute()]
        public CryptoKeySecurity(CommonSecurityDescriptor securityDescriptor)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.AccessRule" /> class with the specified values.</summary><returns>The <see cref="T:System.Security.AccessControl.AccessRule" /> object that this method creates.</returns><param name="identityReference">The identity to which the access rule applies.  It must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="accessMask">The access mask of this rule. The access mask is a 32-bit collection of anonymous bits, the meaning of which is defined by the individual integrators.</param><param name="isInherited">true if this rule is inherited from a parent container.</param><param name="inheritanceFlags">Specifies the inheritance properties of the access rule.</param><param name="propagationFlags">Specifies whether inherited access rules are automatically propagated. The propagation flags are ignored if <paramref name="inheritanceFlags" /> is set to <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="type">Specifies the valid access control type.</param>
        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.AuditRule" /> class with the specified values.</summary><returns>The <see cref="T:System.Security.AccessControl.AuditRule" /> object that this method creates.</returns><param name="identityReference">The identity to which the audit rule applies.  It must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="accessMask">The access mask of this rule. The access mask is a 32-bit collection of anonymous bits, the meaning of which is defined by the individual integrators.</param><param name="isInherited">true if this rule is inherited from a parent container.</param><param name="inheritanceFlags">Specifies the inheritance properties of the audit rule.</param><param name="propagationFlags">Specifies whether inherited audit rules are automatically propagated. The propagation flags are ignored if <paramref name="inheritanceFlags" /> is set to <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="flags">Specifies the conditions for which the rule is audited.</param>
        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified access rule to the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><param name="rule">The access rule to add.</param>
        public void AddAccessRule(CryptoKeyAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules that contain the same security identifier and qualifier as the specified access rule in the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object and then adds the specified access rule.</summary><param name="rule">The access rule to set.</param>
        public void SetAccessRule(CryptoKeyAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules in the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object and then adds the specified access rule.</summary><param name="rule">The access rule to reset.</param>
        public void ResetAccessRule(CryptoKeyAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes access rules that contain the same security identifier and access mask as the specified access rule from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><returns>true if the access rule was successfully removed; otherwise, false.</returns><param name="rule">The access rule to remove.</param>
        public bool RemoveAccessRule(CryptoKeyAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules that have the same security identifier as the specified access rule from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><param name="rule">The access rule to remove.</param>
        public void RemoveAccessRuleAll(CryptoKeyAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules that exactly match the specified access rule from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><param name="rule">The access rule to remove.</param>
        public void RemoveAccessRuleSpecific(CryptoKeyAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified audit rule to the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><param name="rule">The audit rule to add.</param>
        public void AddAuditRule(CryptoKeyAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules that contain the same security identifier and qualifier as the specified audit rule in the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object and then adds the specified audit rule.</summary><param name="rule">The audit rule to set.</param>
        public void SetAuditRule(CryptoKeyAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes audit rules that contain the same security identifier and access mask as the specified audit rule from the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><returns>true if the audit rule was successfully removed; otherwise, false.</returns><param name="rule">The audit rule to remove.</param>
        public bool RemoveAuditRule(CryptoKeyAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules that have the same security identifier as the specified audit rule from the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><param name="rule">The audit rule to remove.</param>
        public void RemoveAuditRuleAll(CryptoKeyAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules that exactly match the specified audit rule from the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object.</summary><param name="rule">The audit rule to remove.</param>
        public void RemoveAuditRuleSpecific(CryptoKeyAuditRule rule)
        {
             throw new NotImplementedException();
        }
    }
}
