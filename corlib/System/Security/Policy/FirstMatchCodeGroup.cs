using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Allows security policy to be defined by the union of the policy statement of a code group and that of the first child code group that matches. This class cannot be inherited.</summary>
    [Serializable]
    [ObsoleteAttribute("This type is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
    [ComVisibleAttribute(true)]
    public sealed class FirstMatchCodeGroup : CodeGroup
    {
        /// <summary>Gets the merge logic.</summary><returns>The string "First Match".</returns>
        public override string MergeLogic
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.FirstMatchCodeGroup" /> class.</summary><param name="membershipCondition">A membership condition that tests evidence to determine whether this code group applies policy. </param><param name="policy">The policy statement for the code group in the form of a permission set and attributes to grant code that matches the membership condition. </param><exception cref="T:System.ArgumentException">The type of the <paramref name="membershipCondition" /> parameter is not valid.-or- The type of the <paramref name="policy" /> parameter is not valid. </exception>
        public FirstMatchCodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy)
            : base(null, null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves policy for the code group and its descendants for a set of evidence.</summary><returns>A policy statement consisting of the permissions granted by the code group with optional attributes, or null if the code group does not apply (the membership condition does not match the specified evidence).</returns><param name="evidence">The evidence for the assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception><exception cref="T:System.Security.Policy.PolicyException">More than one code group (including the parent code group and any child code groups) is marked <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
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
        
        
    }
}
