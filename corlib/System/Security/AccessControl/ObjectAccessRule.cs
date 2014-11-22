using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents a combination of a user's identity, an access mask, and an access control type (allow or deny). An <see cref="T:System.Security.AccessControl.ObjectAccessRule" /> object also contains information about the type of object to which the rule applies, the type of child object that can inherit the rule, how the rule is inherited by child objects, and how that inheritance is propagated.</summary>
    public abstract class ObjectAccessRule : AccessRule
    {
    
        /// <summary>Gets the type of object to which the <see cref="System.Security.AccessControl.ObjectAccessRule" /> applies.</summary><returns>The type of object to which the <see cref="System.Security.AccessControl.ObjectAccessRule" /> applies.</returns>
        public Guid ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of child object that can inherit the <see cref="System.Security.AccessControl.ObjectAccessRule" /> object.</summary><returns>The type of child object that can inherit the <see cref="System.Security.AccessControl.ObjectAccessRule" /> object.</returns>
        public Guid InheritedObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets flags that specify if the <see cref="P:System.Security.AccessControl.ObjectAccessRule.ObjectType" /> and <see cref="P:System.Security.AccessControl.ObjectAccessRule.InheritedObjectType" /> properties of the <see cref="System.Security.AccessControl.ObjectAccessRule" /> object contain valid values.</summary><returns><see cref="F:System.Security.AccessControl.ObjectAceFlags.ObjectAceTypePresent" /> specifies that the <see cref="P:System.Security.AccessControl.ObjectAccessRule.ObjectType" /> property contains a valid value. <see cref="F:System.Security.AccessControl.ObjectAceFlags.InheritedObjectAceTypePresent" /> specifies that the <see cref="P:System.Security.AccessControl.ObjectAccessRule.InheritedObjectType" /> property contains a valid value. These values can be combined with a logical OR.</returns>
        public ObjectAceFlags ObjectFlags
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.ObjectAccessRule" /> class with the specified values.</summary><param name="identity">The identity to which the access rule applies.  It must be an object that can be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="accessMask">The access mask of this rule. The access mask is a 32-bit collection of anonymous bits, the meaning of which is defined by the individual integrators.</param><param name="isInherited">true if this rule is inherited from a parent container.</param><param name="inheritanceFlags">Specifies the inheritance properties of the access rule.</param><param name="propagationFlags">Specifies whether inherited access rules are automatically propagated. The propagation flags are ignored if <paramref name="inheritanceFlags" /> is set to <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param><param name="objectType">The type of object to which the rule applies.</param><param name="inheritedObjectType">The type of child object that can inherit the rule.</param><param name="type">Specifies whether this rule allows or denies access.</param><exception cref="T:System.ArgumentException">The value of the <paramref name="identity" /> parameter cannot be cast as a <see cref="T:System.Security.Principal.SecurityIdentifier" />, or the <paramref name="type" /> parameter contains an invalid value.</exception><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="accessMask" /> parameter is 0, or the <paramref name="inheritanceFlags" /> or <paramref name="propagationFlags" /> parameters contain unrecognized flag values.</exception>
        protected ObjectAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, Guid objectType, Guid inheritedObjectType, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
