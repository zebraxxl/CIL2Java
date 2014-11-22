using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Provides the ability to control access to objects without direct manipulation fo Access Control Lists (ACLs). </summary><typeparam name="T"></typeparam>
    public abstract class ObjectSecurity<T> : NativeObjectSecurity
    {
        /// <summary>Gets the Type of the securable object associated with this ObjectSecurity’1 object.</summary><returns>Returns <see cref="T:System.Type" />.</returns>
        public override Type AccessRightType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Type of the object associated with the access rules of this ObjectSecurity’1 object. </summary><returns>Returns <see cref="T:System.Type" />.</returns>
        public override Type AccessRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Type object associated with the audit rules of this ObjectSecurity’1 object.</summary><returns>Returns <see cref="T:System.Type" />.</returns>
        public override Type AuditRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the ObjectSecurity’1 class.</summary><param name="isContainer">true is the new <see cref="ObjectSecurity’1" /> object is a container object.</param><param name="resourceType">The type of resource.</param>
        protected ObjectSecurity(bool isContainer, ResourceType resourceType)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the ObjectSecurity’1 class.</summary><param name="isContainer">true is the new <see cref="ObjectSecurity’1" /> object is a container object.</param><param name="resourceType">The type of resource.</param>
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the ObjectSecurity’1 class.</summary><param name="isContainer">true is the new <see cref="ObjectSecurity’1" /> object is a container object.</param><param name="resourceType">The type of resource.</param><param name="safeHandle">A handle.</param><param name="includeSections">The sections to include.</param>
        [SecuritySafeCriticalAttribute()]
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle safeHandle, AccessControlSections includeSections)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected ObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle safeHandle, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <returns>Returns <see cref="T:System.Security.AccessControl.AccessRule" />.</returns>
        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <returns>Returns <see cref="T:System.Security.AccessControl.AuditRule" />.</returns>
        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// 
        [SecuritySafeCriticalAttribute()]
        protected void Persist(SafeHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        /// 
        [SecuritySafeCriticalAttribute()]
        protected void Persist(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AddAccessRule(AccessRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void SetAccessRule(AccessRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void ResetAccessRule(AccessRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool RemoveAccessRule(AccessRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RemoveAccessRuleAll(AccessRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RemoveAccessRuleSpecific(AccessRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AddAuditRule(AuditRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void SetAuditRule(AuditRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool RemoveAuditRule(AuditRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RemoveAuditRuleAll(AuditRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void RemoveAuditRuleSpecific(AuditRule<T> rule)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
