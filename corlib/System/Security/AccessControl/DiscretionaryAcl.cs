using System.Security.Principal;
using System;

namespace System.Security.AccessControl
{
    /// <summary>Represents a Discretionary Access Control List (DACL).</summary>
    public sealed class DiscretionaryAcl : CommonAcl
    {
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> class with the specified values.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object is a container.</param><param name="isDS">true if the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object is a directory object Access Control List (ACL).</param><param name="capacity">The number of Access Control Entries (ACEs) this <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object can contain. This number is to be used only as a hint.</param>
        public DiscretionaryAcl(bool isContainer, bool isDS, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> class with the specified values.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object is a container.</param><param name="isDS">true if the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object is a directory object Access Control List (ACL).</param><param name="revision">The revision level of the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object.</param><param name="capacity">The number of Access Control Entries (ACEs) this <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object can contain. This number is to be used only as a hint.</param>
        public DiscretionaryAcl(bool isContainer, bool isDS, byte revision, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> class with the specified values from the specified <see cref="T:System.Security.AccessControl.RawAcl" /> object.</summary><param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object is a container.</param><param name="isDS">true if the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object is a directory object Access Control List (ACL).</param><param name="rawAcl">The underlying <see cref="T:System.Security.AccessControl.RawAcl" /> object for the new <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object. Specify null to create an empty ACL.</param>
        public DiscretionaryAcl(bool isContainer, bool isDS, RawAcl rawAcl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an Access Control Entry (ACE) with the specified settings to the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object.</summary><param name="accessType">The type of access control (allow or deny) to add.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to add an ACE.</param><param name="accessMask">The access rule for the new ACE.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new ACE.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new ACE.</param>
        public void AddAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified access control for the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><param name="accessType">The type of access control (allow or deny) to set.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to set an ACE.</param><param name="accessMask">The access rule for the new ACE.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new ACE.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new ACE.</param>
        public void SetAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified access control rule from the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object.</summary><returns>true if this method successfully removes the specified access; otherwise, false.</returns><param name="accessType">The type of access control (allow or deny) to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an access control rule.</param><param name="accessMask">The access mask for the rule to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the rule to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the rule to be removed.</param>
        public bool RemoveAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified Access Control Entry (ACE) from the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object.</summary><param name="accessType">The type of access control (allow or deny) to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an ACE.</param><param name="accessMask">The access mask for the ACE to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the ACE to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the ACE to be removed.</param>
        public void RemoveAccessSpecific(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an Access Control Entry (ACE) with the specified settings to the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type for the new ACE.</summary><param name="accessType">The type of access control (allow or deny) to add.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to add an ACE.</param><param name="accessMask">The access rule for the new ACE.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new ACE.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new ACE.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the new ACE applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the new ACE.</param>
        public void AddAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified access control for the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary><param name="accessType">The type of access control (allow or deny) to set.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to set an ACE.</param><param name="accessMask">The access rule for the new ACE.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the new ACE.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the new ACE.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the new ACE applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the new ACE.</param>
        public void SetAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified access control rule from the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type.</summary><returns>true if this method successfully removes the specified access; otherwise, false.</returns><param name="accessType">The type of access control (allow or deny) to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an access control rule.</param><param name="accessMask">The access mask for the access control rule to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the access control rule to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the access control rule to be removed.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the removed access control rule applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the removed access control rule.</param>
        public bool RemoveAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified Access Control Entry (ACE) from the current <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> object. Use this method for directory object Access Control Lists (ACLs) when specifying the object type or the inherited object type for the ACE to be removed.</summary><param name="accessType">The type of access control (allow or deny) to remove.</param><param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> for which to remove an ACE.</param><param name="accessMask">The access mask for the ACE to be removed.</param><param name="inheritanceFlags">Flags that specify the inheritance properties of the ACE to be removed.</param><param name="propagationFlags">Flags that specify the inheritance propagation properties for the ACE to be removed.</param><param name="objectFlags">Flags that specify if the <paramref name="objectType" /> and <paramref name="inheritedObjectType" /> parameters contain non-null values.</param><param name="objectType">The identity of the class of objects to which the removed ACE applies.</param><param name="inheritedObjectType">The identity of the class of child objects which can inherit the removed ACE.</param>
        public void RemoveAccessSpecific(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
