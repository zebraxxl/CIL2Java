using System;
using System.Security;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents the Windows access control security for a named mutex. This class cannot be inherited. </summary>
    public sealed class MutexSecurity : NativeObjectSecurity
    {
        /// <summary>Gets the enumeration that the <see cref="T:System.Security.AccessControl.MutexSecurity" /> class uses to represent access rights.</summary><returns>A <see cref="T:System.Type" /> object representing the <see cref="T:System.Security.AccessControl.MutexRights" /> enumeration.</returns>
        public override Type AccessRightType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type that the <see cref="T:System.Security.AccessControl.MutexSecurity" /> class uses to represent access rules.</summary><returns>A <see cref="T:System.Type" /> object representing the <see cref="T:System.Security.AccessControl.MutexAccessRule" /> class.</returns>
        public override Type AccessRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type that the <see cref="T:System.Security.AccessControl.MutexSecurity" /> class uses to represent audit rules.</summary><returns>A <see cref="T:System.Type" /> object representing the <see cref="T:System.Security.AccessControl.MutexAuditRule" /> class.</returns>
        public override Type AuditRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MutexSecurity()
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.MutexSecurity" /> class with the specified sections of the access control security rules from the system mutex with the specified name.</summary><param name="name">The name of the system mutex whose access control security rules are to be retrieved.</param><param name="includeSections">A combination of <see cref="T:System.Security.AccessControl.AccessControlSections" /> flags specifying the sections to retrieve.</param><exception cref="T:System.IO.FileNotFoundException">There is no system object with the specified name.</exception><exception cref="T:System.NotSupportedException">This class is not supported on Windows 98 or Windows Millennium Edition.</exception>
        [SecuritySafeCriticalAttribute()]
        public MutexSecurity(string name, AccessControlSections includeSections)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new access control rule for the specified user, with the specified access rights, access control, and flags.</summary><returns>A <see cref="T:System.Security.AccessControl.MutexAccessRule" /> object representing the specified rights for the specified user.</returns><param name="identityReference">An <see cref="T:System.Security.Principal.IdentityReference" /> that identifies the user or group the rule applies to.</param><param name="accessMask">A bitwise combination of <see cref="T:System.Security.AccessControl.MutexRights" /> values specifying the access rights to allow or deny, cast to an integer.</param><param name="isInherited">Meaningless for named mutexes, because they have no hierarchy.</param><param name="inheritanceFlags">Meaningless for named mutexes, because they have no hierarchy.</param><param name="propagationFlags">Meaningless for named mutexes, because they have no hierarchy.</param><param name="type">One of the <see cref="T:System.Security.AccessControl.AccessControlType" /> values specifying whether the rights are allowed or denied.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" />, or <paramref name="type" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="identityReference" /> is null. -or-<paramref name="accessMask" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="identityReference" /> is neither of type <see cref="T:System.Security.Principal.SecurityIdentifier" />, nor of a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new audit rule, specifying the user the rule applies to, the access rights to audit, and the outcome that triggers the audit rule.</summary><returns>A <see cref="T:System.Security.AccessControl.MutexAuditRule" /> object representing the specified audit rule for the specified user. The return type of the method is the base class, <see cref="T:System.Security.AccessControl.AuditRule" />, but the return value can be cast safely to the derived class.</returns><param name="identityReference">An <see cref="T:System.Security.Principal.IdentityReference" /> that identifies the user or group the rule applies to.</param><param name="accessMask">A bitwise combination of <see cref="T:System.Security.AccessControl.MutexRights" /> values specifying the access rights to audit, cast to an integer.</param><param name="isInherited">Meaningless for named wait handles, because they have no hierarchy.</param><param name="inheritanceFlags">Meaningless for named wait handles, because they have no hierarchy.</param><param name="propagationFlags">Meaningless for named wait handles, because they have no hierarchy.</param><param name="flags">A bitwise combination of <see cref="T:System.Security.AccessControl.AuditFlags" /> values that specify whether to audit successful access, failed access, or both.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" />, or <paramref name="flags" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="identityReference" /> is null. -or-<paramref name="accessMask" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="identityReference" /> is neither of type <see cref="T:System.Security.Principal.SecurityIdentifier" />, nor of a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for a matching access control rule with which the new rule can be merged. If none are found, adds the new rule.</summary><param name="rule">The access control rule to add.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception><exception cref="T:System.Security.Principal.IdentityNotMappedException"><paramref name="rule " />cannot be mapped to a known identity.</exception>
        public void AddAccessRule(MutexAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access control rules with the same user and <see cref="T:System.Security.AccessControl.AccessControlType" /> (allow or deny) as the specified rule, and then adds the specified rule.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.MutexAccessRule" /> to add. The user and <see cref="T:System.Security.AccessControl.AccessControlType" /> of this rule determine the rules to remove before this rule is added.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void SetAccessRule(MutexAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access control rules with the same user as the specified rule, regardless of <see cref="T:System.Security.AccessControl.AccessControlType" />, and then adds the specified rule.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.MutexAccessRule" /> to add. The user specified by this rule determines the rules to remove before this rule is added.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void ResetAccessRule(MutexAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an access control rule with the same user and <see cref="T:System.Security.AccessControl.AccessControlType" /> (allow or deny) as the specified rule, and with compatible inheritance and propagation flags; if such a rule is found, the rights contained in the specified access rule are removed from it.</summary><returns>true if a compatible rule is found; otherwise false.</returns><param name="rule">A <see cref="T:System.Security.AccessControl.MutexAccessRule" /> that specifies the user and <see cref="T:System.Security.AccessControl.AccessControlType" /> to search for, and a set of inheritance and propagation flags that a matching rule, if found, must be compatible with. Specifies the rights to remove from the compatible rule, if found.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public bool RemoveAccessRule(MutexAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for all access control rules with the same user and <see cref="T:System.Security.AccessControl.AccessControlType" /> (allow or deny) as the specified rule and, if found, removes them.</summary><param name="rule">A <see cref="T:System.Security.AccessControl.MutexAccessRule" /> that specifies the user and <see cref="T:System.Security.AccessControl.AccessControlType" /> to search for. Any rights specified by this rule are ignored.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAccessRuleAll(MutexAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an access control rule that exactly matches the specified rule and, if found, removes it.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.MutexAccessRule" /> to remove.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAccessRuleSpecific(MutexAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an audit rule with which the new rule can be merged. If none are found, adds the new rule.</summary><param name="rule">The audit rule to add. The user specified by this rule determines the search.</param>
        public void AddAuditRule(MutexAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules with the same user as the specified rule, regardless of the <see cref="T:System.Security.AccessControl.AuditFlags" /> value, and then adds the specified rule.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.MutexAuditRule" /> to add. The user specified by this rule determines the rules to remove before this rule is added.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void SetAuditRule(MutexAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an audit control rule with the same user as the specified rule, and with compatible inheritance and propagation flags; if a compatible rule is found, the rights contained in the specified rule are removed from it.</summary><returns>true if a compatible rule is found; otherwise, false.</returns><param name="rule">A <see cref="T:System.Security.AccessControl.MutexAuditRule" /> that specifies the user to search for, and a set of inheritance and propagation flags that a matching rule, if found, must be compatible with. Specifies the rights to remove from the compatible rule, if found.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public bool RemoveAuditRule(MutexAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for all audit rules with the same user as the specified rule and, if found, removes them.</summary><param name="rule">A <see cref="T:System.Security.AccessControl.MutexAuditRule" /> that specifies the user to search for. Any rights specified by this rule are ignored.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAuditRuleAll(MutexAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for an audit rule that exactly matches the specified rule and, if found, removes it.</summary><param name="rule">The <see cref="T:System.Security.AccessControl.MutexAuditRule" /> to be removed.</param><exception cref="T:System.ArgumentNullException"><paramref name="rule" /> is null.</exception>
        public void RemoveAuditRuleSpecific(MutexAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
