using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Determines whether an assembly belongs to a code group by testing its application directory. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ApplicationDirectoryMembershipCondition
    {
        public ApplicationDirectoryMembershipCondition()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the membership condition is satisfied by the specified evidence.</summary><returns>true if the specified evidence satisfies the membership condition; otherwise, false.</returns><param name="evidence">The evidence set against which to make the test. </param>
        public bool Check(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        public IMembershipCondition Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid application directory membership condition element. </exception>
        public void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an XML encoding of the security object and its current state with the specified <see cref="T:System.Security.Policy.PolicyLevel" />.</summary><returns>An XML encoding of the security object, including any state information.</returns><param name="level">The policy level context for resolving named permission set references. </param>
        public SecurityElement ToXml(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><param name="level">The policy level context, used to resolve named permission set references. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid application directory membership condition element. </exception>
        public void FromXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified membership condition is an <see cref="T:System.Security.Policy.ApplicationDirectoryMembershipCondition" />.</summary><returns>true if the specified membership condition is an <see cref="T:System.Security.Policy.ApplicationDirectoryMembershipCondition" />; otherwise, false.</returns><param name="o">The object to compare to <see cref="T:System.Security.Policy.ApplicationDirectoryMembershipCondition" />. </param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
