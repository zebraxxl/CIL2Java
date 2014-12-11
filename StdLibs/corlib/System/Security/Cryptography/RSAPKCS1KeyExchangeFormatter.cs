using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Creates the PKCS#1 key exchange data using <see cref="T:System.Security.Cryptography.RSA" />.</summary>
    [ComVisibleAttribute(true)]
    public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
    
        /// <summary>Gets the parameters for the PKCS #1 key exchange.</summary><returns>An XML string containing the parameters of the PKCS #1 key exchange operation.</returns>
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
    
    
        public RSAPKCS1KeyExchangeFormatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter" /> class with the specified key.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the public key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the public key to use for encrypting the key exchange data.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the public key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public override void SetKey(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the encrypted key exchange data from the specified input data.</summary><returns>The encrypted key exchange data to be sent to the intended recipient.</returns><param name="rgbData">The secret information to be passed in the key exchange. </param><exception cref="T:System.Security.Cryptography.CryptographicException"><paramref name="rgbData " />is too big.</exception><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
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
