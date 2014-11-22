using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Provides the Web site from which a code assembly originates as evidence for policy evaluation. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Site : EvidenceBase, IIdentityPermissionFactory
    {
    
        /// <summary>Gets the website from which the code assembly originates.</summary><returns>The name of the website from which the code assembly originates.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Site" /> class with the website from which a code assembly originates.</summary><param name="name">The website of origin for the associated code assembly. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        public Site(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new <see cref="T:System.Security.Policy.Site" /> object from the specified URL.</summary><returns>A new site object.</returns><param name="url">The URL from which to create the new <see cref="T:System.Security.Policy.Site" /> object. </param><exception cref="T:System.ArgumentException">The <paramref name="url" /> parameter is not a valid URL. -or-The <paramref name="url" /> parameter is a file name.</exception>
        public static Site CreateFromUrl(string url)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an identity permission that corresponds to the current <see cref="T:System.Security.Policy.Site" /> object.</summary><returns>A site identity permission for the current <see cref="T:System.Security.Policy.Site" /> object.</returns><param name="evidence">The evidence from which to construct the identity permission. </param>
        public IPermission CreateIdentityPermission(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.Security.Policy.Site" /> to the specified object for equivalence.</summary><returns>true if the two instances of the <see cref="T:System.Security.Policy.Site" /> class are equal; otherwise, false.</returns><param name="o">The object to test for equivalence with the current object. </param>
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
