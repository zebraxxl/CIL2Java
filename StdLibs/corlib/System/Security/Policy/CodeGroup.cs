using System.Runtime.InteropServices;
using System.Collections;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Represents the abstract base class from which all implementations of code groups must derive.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class CodeGroup
    {
    
        /// <summary>Gets or sets an ordered list of the child code groups of a code group.</summary><returns>A list of child code groups.</returns><exception cref="T:System.ArgumentNullException">An attempt is made to set this property to null. </exception><exception cref="T:System.ArgumentException">An attempt is made to set this property with a list of children that are not <see cref="T:System.Security.Policy.CodeGroup" /> objects.</exception>
        public IList Children
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the code group's membership condition.</summary><returns>The membership condition that determines to which evidence the code group is applicable.</returns><exception cref="T:System.ArgumentNullException">An attempt is made to set this parameter to null. </exception>
        public IMembershipCondition MembershipCondition
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the policy statement associated with the code group.</summary><returns>The policy statement for the code group.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public PolicyStatement PolicyStatement
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the code group.</summary><returns>The name of the code group.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the description of the code group.</summary><returns>The description of the code group.</returns>
        public string Description
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the named permission set for the code group.</summary><returns>The name of a named permission set of the policy level.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual string PermissionSetName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representation of the attributes of the policy statement for the code group.</summary><returns>A string representation of the attributes of the policy statement for the code group.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual string AttributeString
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the merge logic for the code group.</summary><returns>A description of the merge logic for the code group.</returns>
        public abstract string MergeLogic
        {
            get;
        }
    
    
        /// <summary>Initializes a new instance of <see cref="T:System.Security.Policy.CodeGroup" />.</summary><param name="membershipCondition">A membership condition that tests evidence to determine whether this code group applies policy. </param><param name="policy">The policy statement for the code group in the form of a permission set and attributes to grant code that matches the membership condition. </param><exception cref="T:System.ArgumentNullException">The <paramref name="membershipCondition" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The type of the <paramref name="membershipCondition" /> parameter is not valid.-or- The type of the <paramref name="policy" /> parameter is not valid. </exception>
        protected CodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a child code group to the current code group.</summary><param name="group">The code group to be added as a child. This new child code group is added to the end of the list. </param><exception cref="T:System.ArgumentNullException">The <paramref name="group" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="group" /> parameter is not a valid code group. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddChild(CodeGroup group)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified child code group.</summary><param name="group">The code group to be removed as a child. </param><exception cref="T:System.ArgumentException">The <paramref name="group" /> parameter is not an immediate child code group of the current code group. </exception>
        [SecuritySafeCriticalAttribute()]
        public void RemoveChild(CodeGroup group)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, resolves policy for the code group and its descendants for a set of evidence.</summary><returns>A policy statement that consists of the permissions granted by the code group with optional attributes, or null if the code group does not apply (the membership condition does not match the specified evidence).</returns><param name="evidence">The evidence for the assembly. </param>
        public abstract PolicyStatement Resolve(Evidence evidence);
        
        
        /// <summary>When overridden in a derived class, resolves matching code groups.</summary><returns>A <see cref="T:System.Security.Policy.CodeGroup" /> that is the root of the tree of matching code groups.</returns><param name="evidence">The evidence for the assembly. </param>
        public abstract CodeGroup ResolveMatchingCodeGroups(Evidence evidence);
        
        
        public abstract CodeGroup Copy();
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a given state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception>
        public void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an XML encoding of the security object, its current state, and the policy level within which the code exists.</summary><returns>An XML encoding of the security object, including any state information.</returns><param name="level">The policy level within which the code group exists. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public SecurityElement ToXml(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, serializes properties and internal state specific to a derived code group and adds the serialization to the specified <see cref="T:System.Security.SecurityElement" />.</summary><param name="element">The XML encoding to which to add the serialization. </param><param name="level">The policy level within which the code group exists. </param>
        protected virtual void CreateXml(SecurityElement element, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a given state and policy level from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><param name="level">The policy level within which the code group exists. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception>
        public void FromXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, reconstructs properties and internal state specific to a derived code group from the specified <see cref="T:System.Security.SecurityElement" />.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><param name="level">The policy level within which the code group exists. </param>
        protected virtual void ParseXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified code group is equivalent to the current code group.</summary><returns>true if the specified code group is equivalent to the current code group; otherwise, false.</returns><param name="o">The code group to compare with the current code group. </param>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified code group is equivalent to the current code group, checking the child code groups as well, if specified.</summary><returns>true if the specified code group is equivalent to the current code group; otherwise, false.</returns><param name="cg">The code group to compare with the current code group. </param><param name="compareChildren">true to compare child code groups, as well; otherwise, false. </param>
        [SecuritySafeCriticalAttribute()]
        public bool Equals(CodeGroup cg, bool compareChildren)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
