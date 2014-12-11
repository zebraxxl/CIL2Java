using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the base class from which all asymmetric key exchange deformatters derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class AsymmetricKeyExchangeDeformatter
    {
        /// <summary>When overridden in a derived class, gets or sets the parameters for the asymmetric key exchange.</summary><returns>A string in XML format containing the parameters of the asymmetric key exchange operation.</returns>
        public abstract string Parameters
        {
            get;
            set;
        }
    
    
        protected AsymmetricKeyExchangeDeformatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, sets the private key to use for decrypting the secret information.</summary><param name="key">The instance of the implementation of <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" /> that holds the private key. </param>
        public abstract void SetKey(AsymmetricAlgorithm key);
        
        
        /// <summary>When overridden in a derived class, extracts secret information from the encrypted key exchange data.</summary><returns>The secret information derived from the key exchange data.</returns><param name="rgb">The key exchange data within which the secret information is hidden. </param>
        public abstract byte[] DecryptKeyExchange(byte[] rgb);
        
        
    }
}
