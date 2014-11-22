using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Defines the test to determine whether a code assembly is a member of a code group.</summary>
    [ComVisibleAttribute(true)]
    public interface IMembershipCondition : ISecurityEncodable, ISecurityPolicyEncodable
    {
        /// <summary>Determines whether the specified evidence satisfies the membership condition.</summary><returns>true if the specified evidence satisfies the membership condition; otherwise, false.</returns><param name="evidence">The evidence set against which to make the test. </param>
        bool Check(Evidence evidence);
        
        
        IMembershipCondition Copy();
        
        
        string ToString();
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.</summary><returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns><param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />. </param>
        bool Equals(object obj);
        
        
    }
}
