using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Confirms that a code assembly originates in the global assembly cache (GAC) as evidence for policy evaluation. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class GacInstalled : EvidenceBase, IIdentityPermissionFactory
    {
        public GacInstalled()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new identity permission that corresponds to the current object.</summary><returns>A new <see cref="T:System.Security.Permissions.GacIdentityPermission" />.</returns><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> from which to construct the identity permission. </param>
        public IPermission CreateIdentityPermission(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current object is equivalent to the specified object.</summary><returns>true if <paramref name="o" /> is a <see cref="T:System.Security.Policy.GacInstalled" /> object; otherwise, false.</returns><param name="o">The object to compare with the current object. </param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public object Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
