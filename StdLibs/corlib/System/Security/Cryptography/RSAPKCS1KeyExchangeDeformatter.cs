using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Decrypts the PKCS #1 key exchange data.</summary>
    [ComVisibleAttribute(true)]
    public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
    
        /// <summary>Gets or sets the random number generator algorithm to use in the creation of the key exchange.</summary><returns>The instance of a random number generator algorithm to use.</returns>
        public RandomNumberGenerator RNG
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the parameters for the PKCS #1 key exchange.</summary><returns>An XML string containing the parameters of the PKCS #1 key exchange operation.</returns>
        public override string Parameters
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public RSAPKCS1KeyExchangeDeformatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter" /> class with the specified key.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null.</exception>
        public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Extracts secret information from the encrypted key exchange data.</summary><returns>The secret information derived from the key exchange data.</returns><param name="rgbIn">The key exchange data within which the secret information is hidden. </param><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is missing.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override byte[] DecryptKeyExchange(byte[] rgbIn)
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
