using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Decrypts Optimal Asymmetric Encryption Padding (OAEP) key exchange data.</summary>
    [ComVisibleAttribute(true)]
    public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
    
        /// <summary>Gets the parameters for the Optimal Asymmetric Encryption Padding (OAEP) key exchange.</summary><returns>An XML string containing the parameters of the OAEP key exchange operation.</returns>
        public override string Parameters
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public RSAOAEPKeyExchangeDeformatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter" /> class with the specified key.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Extracts secret information from the encrypted key exchange data.</summary><returns>The secret information derived from the key exchange data.</returns><param name="rgbData">The key exchange data within which the secret information is hidden. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The key exchange data verification has failed. </exception><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is missing.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override byte[] DecryptKeyExchange(byte[] rgbData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the private key to use for decrypting the secret information.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null.</exception>
        public override void SetKey(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
