using System;

namespace System.Security.AccessControl
{
    /// <summary>Controls access to objects without direct manipulation of access control lists (ACLs). This class is the abstract base class for the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> class.</summary>
    public abstract class CommonObjectSecurity : ObjectSecurity
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> class.</summary><param name="isContainer">true if the new object is a container object.</param>
        protected CommonObjectSecurity(bool isContainer)
            : base(false, false)
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, ref bool modified)
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, ref bool modified)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified access rule to the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><param name="rule">The access rule to add.</param>
        protected void AddAccessRule(AccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules that contain the same security identifier and qualifier as the specified access rule in the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object and then adds the specified access rule.</summary><param name="rule">The access rule to set.</param>
        protected void SetAccessRule(AccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules in the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object and then adds the specified access rule.</summary><param name="rule">The access rule to reset.</param>
        protected void ResetAccessRule(AccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes access rules that contain the same security identifier and access mask as the specified access rule from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><returns>true if the access rule was successfully removed; otherwise, false.</returns><param name="rule">The access rule to remove.</param>
        protected bool RemoveAccessRule(AccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules that have the same security identifier as the specified access rule from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><param name="rule">The access rule to remove.</param>
        protected void RemoveAccessRuleAll(AccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all access rules that exactly match the specified access rule from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><param name="rule">The access rule to remove.</param>
        protected void RemoveAccessRuleSpecific(AccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified audit rule to the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><param name="rule">The audit rule to add.</param>
        protected void AddAuditRule(AuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules that contain the same security identifier and qualifier as the specified audit rule in the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object and then adds the specified audit rule.</summary><param name="rule">The audit rule to set.</param>
        protected void SetAuditRule(AuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes audit rules that contain the same security identifier and access mask as the specified audit rule from the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><returns>true if the audit rule was successfully removed; otherwise, false.</returns><param name="rule">The audit rule to remove.</param>
        protected bool RemoveAuditRule(AuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules that have the same security identifier as the specified audit rule from the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><param name="rule">The audit rule to remove.</param>
        protected void RemoveAuditRuleAll(AuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes all audit rules that exactly match the specified audit rule from the System Access Control List (SACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary><param name="rule">The audit rule to remove.</param>
        protected void RemoveAuditRuleSpecific(AuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a collection of the access rules associated with the specified security identifier.</summary><returns>The collection of access rules associated with the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns><param name="includeExplicit">true to include access rules explicitly set for the object.</param><param name="includeInherited">true to include inherited access rules.</param><param name="targetType">Specifies whether the security identifier for which to retrieve access rules is of type T:System.Security.Principal.SecurityIdentifier or type T:System.Security.Principal.NTAccount. The value of this parameter must be a type that can be translated to  the <see cref="T:System.Security.Principal.SecurityIdentifier" /> type.</param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a collection of the audit rules associated with the specified security identifier.</summary><returns>The collection of audit rules associated with the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns><param name="includeExplicit">true to include audit rules explicitly set for the object.</param><param name="includeInherited">true to include inherited audit rules.</param><param name="targetType">The security identifier for which to retrieve audit rules. This must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
