using System;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Provides the ability to control access to objects without direct manipulation of Access Control Lists (ACLs). This class is the abstract base class for the <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> and <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" /> classes.</summary>
    public abstract class ObjectSecurity
    {
    
        /// <summary>Gets or sets a Boolean value that specifies whether the owner of the securable object has been modified.</summary><returns>true if the owner of the securable object has been modified; otherwise, false.</returns>
        protected bool OwnerModified
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a Boolean value that specifies whether the group associated with the securable object has been modified. </summary><returns>true if the group associated with the securable object has been modified; otherwise, false.</returns>
        protected bool GroupModified
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a Boolean value that specifies whether the audit rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object have been modified.</summary><returns>true if the audit rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object have been modified; otherwise, false.</returns>
        protected bool AuditRulesModified
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a Boolean value that specifies whether the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object have been modified.</summary><returns>true if the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object have been modified; otherwise, false.</returns>
        protected bool AccessRulesModified
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a container object.</summary><returns>true if the <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a container object; otherwise, false.</returns>
        protected bool IsContainer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a directory object.</summary><returns>true if the <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a directory object; otherwise, false.</returns>
        protected bool IsDS
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is protected.</summary><returns>true if the DACL is protected; otherwise, false.</returns>
        public bool AreAccessRulesProtected
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is protected.</summary><returns>true if the SACL is protected; otherwise, false.</returns>
        public bool AreAuditRulesProtected
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object are in canonical order.</summary><returns>true if the access rules are in canonical order; otherwise, false.</returns>
        public bool AreAccessRulesCanonical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a Boolean value that specifies whether the audit rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object are in canonical order.</summary><returns>true if the audit rules are in canonical order; otherwise, false.</returns>
        public bool AreAuditRulesCanonical
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the securable object associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary><returns>The type of the securable object associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</returns>
        public abstract Type AccessRightType
        {
            get;
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the object associated with the access rules of this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object. The <see cref="T:System.Type" /> object must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>The type of the object associated with the access rules of this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</returns>
        public abstract Type AccessRuleType
        {
            get;
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> object associated with the audit rules of this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object. The <see cref="T:System.Type" /> object must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><returns>The type of the object associated with the audit rules of this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</returns>
        public abstract Type AuditRuleType
        {
            get;
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.ObjectSecurity" /> class.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a container object.</param><param name="isDS">True if the new <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a directory object.</param>
        protected ObjectSecurity(bool isContainer, bool isDS)
        {
             throw new NotImplementedException();
        }
        
        
        protected void ReadLock()
        {
             throw new NotImplementedException();
        }
        
        
        protected void ReadUnlock()
        {
             throw new NotImplementedException();
        }
        
        
        protected void WriteLock()
        {
             throw new NotImplementedException();
        }
        
        
        protected void WriteUnlock()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Saves the specified sections of the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object to permanent storage. We recommend that the values of the <paramref name="includeSections" /> parameters passed to the constructor and persist methods be identical. For more information, see Remarks.</summary><param name="name">The name used to retrieve the persisted information.</param><param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> enumeration values that specifies the sections of the security descriptor (access rules, audit rules, owner, primary group) of the securable object to save.</param>
        protected virtual void Persist(string name, AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Saves the specified sections of the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object to permanent storage. We recommend that the values of the <paramref name="includeSections" /> parameters passed to the constructor and persist methods be identical. For more information, see Remarks.</summary><param name="enableOwnershipPrivilege">true to enable the privilege that allows the caller to take ownership of the object.</param><param name="name">The name used to retrieve the persisted information.</param><param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> enumeration values that specifies the sections of the security descriptor (access rules, audit rules, owner, primary group) of the securable object to save.</param>
        [HandleProcessCorruptedStateExceptionsAttribute()]
        [SecuritySafeCriticalAttribute()]
        protected virtual void Persist(bool enableOwnershipPrivilege, string name, AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Saves the specified sections of the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object to permanent storage. We recommend that the values of the <paramref name="includeSections" /> parameters passed to the constructor and persist methods be identical. For more information, see Remarks.</summary><param name="handle">The handle used to retrieve the persisted information.</param><param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> enumeration values that specifies the sections of the security descriptor (access rules, audit rules, owner, primary group) of the securable object to save.</param>
        [SecuritySafeCriticalAttribute()]
        protected virtual void Persist(SafeHandle handle, AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the owner associated with the specified primary group.</summary><returns>The owner associated with the specified group.</returns><param name="targetType">The primary group for which to get the owner.</param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public IdentityReference GetOwner(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the owner for the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary><param name="identity">The owner to set.</param>
        public void SetOwner(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the primary group associated with the specified owner.</summary><returns>The primary group associated with the specified owner.</returns><param name="targetType">The owner for which to get the primary group. </param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public IdentityReference GetGroup(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the primary group for the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary><param name="identity">The primary group to set.</param>
        public void SetGroup(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules associated with the specified <see cref="T:System.Security.Principal.IdentityReference" />.</summary><param name="identity">The <see cref="T:System.Security.Principal.IdentityReference" /> for which to remove all access rules.</param><exception cref="T:System.InvalidOperationException">All access rules are not in canonical order.</exception>
        public virtual void PurgeAccessRules(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules associated with the specified <see cref="T:System.Security.Principal.IdentityReference" />.</summary><param name="identity">The <see cref="T:System.Security.Principal.IdentityReference" /> for which to remove all audit rules.</param><exception cref="T:System.InvalidOperationException">All audit rules are not in canonical order.</exception>
        public virtual void PurgeAuditRules(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets or removes protection of the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object. Protected access rules cannot be modified by parent objects through inheritance.</summary><param name="isProtected">true to protect the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from inheritance; false to allow inheritance.</param><param name="preserveInheritance">true to preserve inherited access rules; false to remove inherited access rules. This parameter is ignored if <paramref name="isProtected" /> is false.</param><exception cref="T:System.InvalidOperationException">This method attempts to remove inherited rules from a non-canonical Discretionary Access Control List (DACL).</exception>
        public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets or removes protection of the audit rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object. Protected audit rules cannot be modified by parent objects through inheritance.</summary><param name="isProtected">true to protect the audit rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from inheritance; false to allow inheritance.</param><param name="preserveInheritance">true to preserve inherited audit rules; false to remove inherited audit rules. This parameter is ignored if <paramref name="isProtected" /> is false.</param><exception cref="T:System.InvalidOperationException">This method attempts to remove inherited rules from a non-canonical System Access Control List (SACL).</exception>
        public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsSddlConversionSupported()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the Security Descriptor Definition Language (SDDL) representation of the specified sections of the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary><returns>The SDDL representation of the specified sections of the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</returns><param name="includeSections">Specifies which sections (access rules, audit rules, primary group, owner) of the security descriptor to get.</param>
        public string GetSecurityDescriptorSddlForm(AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the security descriptor for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from the specified Security Descriptor Definition Language (SDDL) string.</summary><param name="sddlForm">The SDDL string from which to set the security descriptor.</param>
        public void SetSecurityDescriptorSddlForm(string sddlForm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified sections of the security descriptor for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from the specified Security Descriptor Definition Language (SDDL) string.</summary><param name="sddlForm">The SDDL string from which to set the security descriptor.</param><param name="includeSections">The sections (access rules, audit rules, owner, primary group) of the security descriptor to set.</param>
        public void SetSecurityDescriptorSddlForm(string sddlForm, AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetSecurityDescriptorBinaryForm()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the security descriptor for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from the specified array of byte values.</summary><param name="binaryForm">The array of bytes from which to set the security descriptor.</param>
        public void SetSecurityDescriptorBinaryForm(byte[] binaryForm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified sections of the security descriptor for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from the specified array of byte values.</summary><param name="binaryForm">The array of bytes from which to set the security descriptor.</param><param name="includeSections">The sections (access rules, audit rules, owner, primary group) of the security descriptor to set.</param>
        public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract bool ModifyAccess(AccessControlModification modification, AccessRule rule, ref bool modified);
        
        
        protected abstract bool ModifyAudit(AccessControlModification modification, AuditRule rule, ref bool modified);
        
        
        public virtual bool ModifyAccessRule(AccessControlModification modification, AccessRule rule, ref bool modified)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool ModifyAuditRule(AccessControlModification modification, AuditRule rule, ref bool modified)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.AccessRule" /> class with the specified values.</summary><returns>The <see cref="T:System.Security.AccessControl.AccessRule" /> object that this method creates.</returns><param name="identityReference">The identity to which the access rule applies.  It must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="accessMask">The access mask of this rule. The access mask is a 32-bit collection of anonymous bits, the meaning of which is defined by the individual integrators.</param><param name="isInherited">true if this rule is inherited from a parent container.</param><param name="inheritanceFlags">Specifies the inheritance properties of the access rule.</param><param name="propagationFlags">Specifies whether inherited access rules are automatically propagated. The propagation flags are ignored if <paramref name="inheritanceFlags" /> is set to <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="type">Specifies the valid access control type.</param>
        public abstract AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.AuditRule" /> class with the specified values.</summary><returns>The <see cref="T:System.Security.AccessControl.AuditRule" /> object that this method creates.</returns><param name="identityReference">The identity to which the audit rule applies.  It must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="accessMask">The access mask of this rule. The access mask is a 32-bit collection of anonymous bits, the meaning of which is defined by the individual integrators.</param><param name="isInherited">true if this rule is inherited from a parent container.</param><param name="inheritanceFlags">Specifies the inheritance properties of the audit rule.</param><param name="propagationFlags">Specifies whether inherited audit rules are automatically propagated. The propagation flags are ignored if <paramref name="inheritanceFlags" /> is set to <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="flags">Specifies the conditions for which the rule is audited.</param>
        public abstract AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
        
        
    }
}
