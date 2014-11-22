using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Grants Web permission to the site from which the assembly was downloaded. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class NetCodeGroup : CodeGroup
    {
        /// <summary>Contains a value used to specify any other unspecified origin scheme.</summary>
        public static readonly string AnyOtherOriginScheme;
        /// <summary>Contains a value used to specify connection access for code with an unknown or unrecognized origin scheme.</summary>
        public static readonly string AbsentOriginScheme;
    
        /// <summary>Gets the logic to use for merging groups.</summary><returns>The string "Union".</returns>
        public override string MergeLogic
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the <see cref="T:System.Security.NamedPermissionSet" /> for the code group.</summary><returns>Always the string "Same site Web."</returns>
        public override string PermissionSetName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representation of the attributes of the policy statement for the code group.</summary><returns>Always null.</returns>
        public override string AttributeString
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.NetCodeGroup" /> class.</summary><param name="membershipCondition">A membership condition that tests evidence to determine whether this code group applies code access security policy. </param><exception cref="T:System.ArgumentNullException">The <paramref name="membershipCondition" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The type of the <paramref name="membershipCondition" /> parameter is not valid. </exception>
        public NetCodeGroup(IMembershipCondition membershipCondition)
            : base(null, null)
        {
             throw new NotImplementedException();
        }
        
        
        public void ResetConnectAccess()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the specified connection access to the current code group.</summary><param name="originScheme">A <see cref="T:System.String" /> containing the scheme to match against the code's scheme.</param><param name="connectAccess">A <see cref="T:System.Security.Policy.CodeConnectAccess" /> that specifies the scheme and port code can use to connect back to its origin server.</param><exception cref="T:System.ArgumentNullException"><paramref name="originScheme" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="originScheme" /> contains characters that are not permitted in schemes.-or-<paramref name="originScheme" /> = <see cref="F:System.Security.Policy.NetCodeGroup.AbsentOriginScheme" /> and <paramref name="connectAccess" /> specifies <see cref="F:System.Security.Policy.CodeConnectAccess.OriginScheme" /> as its scheme.</exception>
        public void AddConnectAccess(string originScheme, CodeConnectAccess connectAccess)
        {
             throw new NotImplementedException();
        }
        
        
        public DictionaryEntry[] GetConnectAccessRules()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves policy for the code group and its descendants for a set of evidence.</summary><returns>A <see cref="T:System.Security.Policy.PolicyStatement" /> that consists of the permissions granted by the code group with optional attributes, or null if the code group does not apply (the membership condition does not match the specified evidence).</returns><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> for the assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception><exception cref="T:System.Security.Policy.PolicyException">More than one code group (including the parent code group and any child code groups) is marked <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override PolicyStatement Resolve(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resolves matching code groups.</summary><returns>The complete set of code groups that were matched by the evidence.</returns><param name="evidence">The evidence for the assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="evidence" /> parameter is null. </exception>
        public override CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        public override CodeGroup Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified code group is equivalent to the current code group.</summary><returns>true if the specified code group is equivalent to the current code group; otherwise, false.</returns><param name="o">The <see cref="T:System.Security.Policy.NetCodeGroup" /> object to compare with the current code group.</param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
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
        
        
    }
}
