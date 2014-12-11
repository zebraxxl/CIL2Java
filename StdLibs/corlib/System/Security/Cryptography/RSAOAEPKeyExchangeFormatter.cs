using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Creates Optimal Asymmetric Encryption Padding (OAEP) key exchange data using <see cref="T:System.Security.Cryptography.RSA" />.</summary>
    [ComVisibleAttribute(true)]
    public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
    
        /// <summary>Gets or sets the parameter used to create padding in the key exchange creation process.</summary><returns>The parameter value.</returns>
        public byte[] Parameter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the parameters for the Optimal Asymmetric Encryption Padding (OAEP) key exchange.</summary><returns>An XML string containing the parameters of the OAEP key exchange operation.</returns>
        public override string Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the random number generator algorithm to use in the creation of the key exchange.</summary><returns>The instance of a random number generator algorithm to use.</returns>
        public RandomNumberGenerator Rng
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public RSAOAEPKeyExchangeFormatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeFormatter" /> class with the specified key.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the public key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the public key to use for encrypting the key exchange data.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the public key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public override void SetKey(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the encrypted key exchange data from the specified input data.</summary><returns>The encrypted key exchange data to be sent to the intended recipient.</returns><param name="rgbData">The secret information to be passed in the key exchange. </param><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is missing.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override byte[] CreateKeyExchange(byte[] rgbData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the encrypted key exchange data from the specified input data.</summary><returns>The encrypted key exchange data to be sent to the intended recipient.</returns><param name="rgbData">The secret information to be passed in the key exchange. </param><param name="symAlgType">This parameter is not used in the current version. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
