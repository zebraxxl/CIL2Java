using System.Runtime.InteropServices;
using System.Security;
using System.Collections.Generic;

namespace System.Security.Policy
{
    /// <summary>Represents the statement of a <see cref="T:System.Security.Policy.CodeGroup" /> describing the permissions and other information that apply to code with a particular set of evidence. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class PolicyStatement : ISecurityPolicyEncodable, ISecurityEncodable
    {
    
        /// <summary>Gets or sets the <see cref="T:System.Security.PermissionSet" /> of the policy statement.</summary><returns>The <see cref="T:System.Security.PermissionSet" /> of the policy statement.</returns>
        public PermissionSet PermissionSet
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the attributes of the policy statement.</summary><returns>The attributes of the policy statement.</returns>
        public PolicyStatementAttribute Attributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representation of the attributes of the policy statement.</summary><returns>A text string representing the attributes of the policy statement.</returns>
        public string AttributeString
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.PolicyStatement" /> class with the specified <see cref="T:System.Security.PermissionSet" />.</summary><param name="permSet">The <see cref="T:System.Security.PermissionSet" /> with which to initialize the new instance. </param>
        public PolicyStatement(PermissionSet permSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.PolicyStatement" /> class with the specified <see cref="T:System.Security.PermissionSet" /> and attributes.</summary><param name="permSet">The <see cref="T:System.Security.PermissionSet" /> with which to initialize the new instance. </param><param name="attributes">A bitwise combination of the <see cref="T:System.Security.Policy.PolicyStatementAttribute" /> values. </param>
        public PolicyStatement(PermissionSet permSet, PolicyStatementAttribute attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public PolicyStatement Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a given state from an XML encoding.</summary><param name="et">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="et" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="et" /> parameter is not a valid <see cref="T:System.Security.Policy.PolicyStatement" /> encoding. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        public void FromXml(SecurityElement et)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an XML encoding of the security object and its current state.</summary><returns>An XML encoding of the security object, including any state information.</returns><param name="level">The <see cref="T:System.Security.Policy.PolicyLevel" /> context for lookup of <see cref="T:System.Security.NamedPermissionSet" /> values. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public SecurityElement ToXml(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a given state from an XML encoding.</summary><param name="et">The XML encoding to use to reconstruct the security object. </param><param name="level">The <see cref="T:System.Security.Policy.PolicyLevel" /> context for lookup of <see cref="T:System.Security.NamedPermissionSet" /> values. </param><exception cref="T:System.ArgumentNullException">The <paramref name="et" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="et" /> parameter is not a valid <see cref="T:System.Security.Policy.PolicyStatement" /> encoding. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void FromXml(SecurityElement et, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.Policy.PolicyStatement" /> object is equal to the current <see cref="T:System.Security.Policy.PolicyStatement" />.</summary><returns>true if the specified <see cref="T:System.Security.Policy.PolicyStatement" /> is equal to the current <see cref="T:System.Security.Policy.PolicyStatement" /> object; otherwise, false.</returns><param name="obj">The <see cref="T:System.Security.Policy.PolicyStatement" /> object to compare with the current <see cref="T:System.Security.Policy.PolicyStatement" />. </param>
        [ComVisibleAttribute(false)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
