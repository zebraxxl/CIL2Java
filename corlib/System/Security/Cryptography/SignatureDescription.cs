using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Contains information about the properties of a digital signature.</summary>
    [ComVisibleAttribute(true)]
    public class SignatureDescription
    {
    
        /// <summary>Gets or sets the key algorithm for the signature description.</summary><returns>The key algorithm for the signature description.</returns>
        public string KeyAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the digest algorithm for the signature description.</summary><returns>The digest algorithm for the signature description.</returns>
        public string DigestAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the formatter algorithm for the signature description.</summary><returns>The formatter algorithm for the signature description.</returns>
        public string FormatterAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the deformatter algorithm for the signature description.</summary><returns>The deformatter algorithm for the signature description.</returns>
        public string DeformatterAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SignatureDescription()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SignatureDescription" /> class from the specified <see cref="T:System.Security.SecurityElement" />.</summary><param name="el">The <see cref="T:System.Security.SecurityElement" /> from which to get the algorithms for the signature description. </param><exception cref="T:System.ArgumentNullException">The <paramref name="el" /> parameter is null.</exception>
        public SignatureDescription(SecurityElement el)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" /> instance with the specified key using the <see cref="P:System.Security.Cryptography.SignatureDescription.DeformatterAlgorithm" /> property.</summary><returns>The newly created <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" /> instance.</returns><param name="key">The key to use in the <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" />. </param>
        public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" /> instance with the specified key using the <see cref="P:System.Security.Cryptography.SignatureDescription.FormatterAlgorithm" /> property.</summary><returns>The newly created <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" /> instance.</returns><param name="key">The key to use in the <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" />. </param>
        public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual HashAlgorithm CreateDigest()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
