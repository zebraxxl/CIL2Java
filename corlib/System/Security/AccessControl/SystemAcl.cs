using System.Security.Principal;
using System;

namespace System.Security.AccessControl
{
    /// <summary>Represents a System Access Control List (SACL).</summary>
    public sealed class SystemAcl : CommonAcl
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.SystemAcl" /> class with the specified values.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a container.</param><param name="isDS">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a directory object Access Control List (ACL).</param><param name="capacity">The number of Access Control Entries (ACEs) this <see cref="T:System.Security.AccessControl.SystemAcl" /> object can contain. This number is to be used only as a hint.</param>
        public SystemAcl(bool isContainer, bool isDS, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.SystemAcl" /> class with the specified values.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a container.</param><param name="isDS">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a directory object Access Control List (ACL).</param><param name="revision">The revision level of the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object.</param><param name="capacity">The number of Access Control Entries (ACEs) this <see cref="T:System.Security.AccessControl.SystemAcl" /> object can contain. This number is to be used only as a hint.</param>
        public SystemAcl(bool isContainer, bool isDS, byte revision, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.SystemAcl" /> class with the specified values from the specified <see cref="T:System.Security.AccessControl.RawAcl" /> object.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a container.</param><param name="isDS">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a directory object Access Control List (ACL).</param><param name="rawAcl">The underlying <see cref="T:System.Security.AccessControl.RawAcl" /> object for the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object. Specify null to create an empty ACL.</param>
        public SystemAcl(bool isContainer, bool isDS, RawAcl rawAcl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an audit rule to the current <see cref="T:System.Security.AccessControl.SystemAcl" /> object.</summary><param name="auditFlags">The type of audit rule to add.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to add an audit rule.</param><param name="accessMask">The access mask for the new audit rule.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new audit rule.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new audit rule.</param>
        public void AddAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified audit rule for the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><param name="auditFlags">The audit condition to set.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to set an audit rule.</param><param name="accessMask">The access mask for the new audit rule.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new audit rule.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new audit rule.</param>
        public void SetAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified audit rule from the current <see cref="T:System.Security.AccessControl.SystemAcl" /> object.</summary><returns>true if this method successfully removes the specified audit rule; otherwise, false.</returns><param name="auditFlags">The type of audit rule to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an audit rule.</param><param name="accessMask">The access mask for the rule to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the rule to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the rule to be removed.</param>
        public bool RemoveAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified audit rule from the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object.</summary><param name="auditFlags">The type of audit rule to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an audit rule.</param><param name="accessMask">The access mask for the rule to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the rule to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the rule to be removed.</param>
        public void RemoveAuditSpecific(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an audit rule with the specified settings to the current <see cref="T:System.Security.AccessControl.SystemAcl" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type for the new audit rule.</summary><param name="auditFlags">The type of audit rule to add.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to add an audit rule.</param><param name="accessMask">The access mask for the new audit rule.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new audit rule.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new audit rule.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the new audit rule applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the new audit rule.</param>
        public void AddAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified audit rule for the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type.</summary><param name="auditFlags">The audit condition to set.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to set an audit rule.</param><param name="accessMask">The access mask for the new audit rule.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new audit rule.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new audit rule.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the new audit rule applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the new audit rule.</param>
        public void SetAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified audit rule from the current <see cref="T:System.Security.AccessControl.SystemAcl" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type.</summary><returns>true if this method successfully removes the specified audit rule; otherwise, false.</returns><param name="auditFlags">The type of audit rule to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an audit rule.</param><param name="accessMask">The access mask for the rule to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the rule to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the rule to be removed.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the removed audit control rule applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the removed audit rule.</param>
        public bool RemoveAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified audit rule from the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type.</summary><param name="auditFlags">The type of audit rule to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an audit rule.</param><param name="accessMask">The access mask for the rule to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the rule to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the rule to be removed.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the removed audit control rule applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the removed audit rule.</param>
        public void RemoveAuditSpecific(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
