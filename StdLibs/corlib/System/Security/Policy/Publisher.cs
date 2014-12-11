using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Provides the Authenticode X.509v3 digital signature of a code assembly as evidence for policy evaluation. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Publisher : EvidenceBase, IIdentityPermissionFactory
    {
    
        /// <summary>Gets the publisher's Authenticode X.509v3 certificate.</summary><returns>The publisher's <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
        public X509Certificate Certificate
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.Publisher" /> class with the Authenticode X.509v3 certificate containing the publisher's public key.</summary><param name="cert">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> that contains the software publisher's public key. </param><exception cref="T:System.ArgumentNullException">The <paramref name="cert" /> parameter is null. </exception>
        public Publisher(X509Certificate cert)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an identity permission that corresponds to the current instance of the <see cref="T:System.Security.Policy.Publisher" /> class.</summary><returns>A <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> for the specified <see cref="T:System.Security.Policy.Publisher" />.</returns><param name="evidence">The <see cref="T:System.Security.Policy.Evidence" /> from which to construct the identity permission. </param>
        public IPermission CreateIdentityPermission(Evidence evidence)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.Security.Policy.Publisher" /> to the specified object for equivalence.</summary><returns>true if the two instances of the <see cref="T:System.Security.Policy.Publisher" /> class are equal; otherwise, false.</returns><param name="o">The <see cref="T:System.Security.Policy.Publisher" /> to test for equivalence with the current object. </param><exception cref="T:System.ArgumentException">The <paramref name="o" /> parameter is not a <see cref="T:System.Security.Policy.Publisher" /> object. </exception>
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
