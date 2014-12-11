using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Determines whether an assembly belongs to a code group by testing its URL. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class UrlMembershipCondition
    {
    
        /// <summary>Gets or sets the URL for which the membership condition tests.</summary><returns>The URL for which the membership condition tests.</returns><exception cref="T:System.ArgumentNullException">An attempt is made to set <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> to null. </exception><exception cref="T:System.ArgumentException">Value is not an absolute URL.</exception>
        public string Url
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.UrlMembershipCondition" /> class with the URL that determines membership.</summary><param name="url">The URL for which to test. </param><exception cref="T:System.ArgumentNullException">The <paramref name="url" /> parameter is null. </exception><exception cref="T:System.ArgumentException"><paramref name="url" /> must be an absolute URL.</exception>
        public UrlMembershipCondition(string url)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified evidence satisfies the membership condition.</summary><returns>true if the specified evidence satisfies the membership condition; otherwise, false.</returns><param name="evidence">The evidence set against which to make the test. </param><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> property is null. </exception>
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
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid membership condition element. </exception>
        public void FromXml(SecurityElement e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an XML encoding of the security object and its current state with the specified <see cref="T:System.Security.Policy.PolicyLevel" />.</summary><returns>An XML encoding of the security object, including any state information.</returns><param name="level">The policy level context for resolving named permission set references. </param><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> property is null. </exception>
        public SecurityElement ToXml(PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="e">The XML encoding to use to reconstruct the security object. </param><param name="level">The policy level context, used to resolve named permission set references. </param><exception cref="T:System.ArgumentNullException">The <paramref name="e" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="e" /> parameter is not a valid membership condition element. </exception>
        public void FromXml(SecurityElement e, PolicyLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the URL from the specified object is equivalent to the URL contained in the current <see cref="T:System.Security.Policy.UrlMembershipCondition" />.</summary><returns>true if the URL from the specified object is equivalent to the URL contained in the current <see cref="T:System.Security.Policy.UrlMembershipCondition" />; otherwise, false.</returns><param name="o">The object to compare to the current <see cref="T:System.Security.Policy.UrlMembershipCondition" />. </param><exception cref="T:System.ArgumentNullException">The <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> property of the current object or the specified object is null. </exception>
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
