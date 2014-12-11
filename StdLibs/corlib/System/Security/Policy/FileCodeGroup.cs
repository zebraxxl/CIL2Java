using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Grants permission to manipulate files located in the code assemblies to code assemblies that match the membership condition. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class FileCodeGroup : CodeGroup
    {
    
        /// <summary>Gets the merge logic.</summary><returns>The string "Union".</returns>
        public override string MergeLogic
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the named permission set for the code group.</summary><returns>The concatenatation of the string "Same directory FileIO - " and the access type.</returns>
        public override string PermissionSetName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representation of the attributes of the policy statement for the code group.</summary><returns>Always null.</returns>
        public override string AttributeString
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.FileCodeGroup" /> class.</summary><param name="membershipCondition">A membership condition that tests evidence to determine whether this code group applies policy. </param><param name="access">One of the <see cref="T:System.Security.Permissions.FileIOPermissionAccess" /> values. This value is used to construct the <see cref="T:System.Security.Permissions.FileIOPermission" /> that is granted. </param><exception cref="T:System.ArgumentNullException">The <paramref name="membershipCondition" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The type of the <paramref name="membershipCondition" /> parameter is not valid.-or- The type of the <paramref name="access" /> parameter is not valid. </exception>
        public FileCodeGroup(IMembershipCondition membershipCondition, FileIOPermissionAccess access)
            : base(null, null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves policy for the code group and its descendants for a set of evidence.</summary><returns>A policy statement consisting of the permissions granted by the code group with optional attributes, or null if the code group does not apply (the membership condition does not match the specified evidence).</returns><param name="evidence">The evidence for the assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception><exception cref="T:System.Security.Policy.PolicyException">The current policy is null.-or- More than one code group (including the parent code group and all child code groups) is marked <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override PolicyStatement Resolve(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves matching code groups.</summary><returns>A <see cref="T:System.Security.Policy.CodeGroup" /> that is the root of the tree of matching code groups.</returns><param name="evidence">The evidence for the assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception>
        public override CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        public override CodeGroup Copy()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void CreateXml(SecurityElement element, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void ParseXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified code group is equivalent to the current code group.</summary><returns>true if the specified code group is equivalent to the current code group; otherwise, false.</returns><param name="o">The code group to compare with the current code group. </param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
