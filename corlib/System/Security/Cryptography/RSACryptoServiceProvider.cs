using System.Runtime.InteropServices;
using System.Security;
using System.IO;

namespace System.Security.Cryptography
{
    /// <summary>Performs asymmetric encryption and decryption using the implementation of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
    {
    
        /// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key.</summary><returns>true if the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key; otherwise, false.</returns>
        [ComVisibleAttribute(false)]
        public bool PublicOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair. </summary><returns>A <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.</returns>
        [ComVisibleAttribute(false)]
        public CspKeyContainerInfo CspKeyContainerInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the size of the current key.</summary><returns>The size of the key in bits.</returns>
        public override int KeySize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the key exchange algorithm available with this implementation of <see cref="T:System.Security.Cryptography.RSA" />.</summary><returns>The name of the key exchange algorithm if it exists; otherwise, null.</returns>
        public override string KeyExchangeAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the signature algorithm available with this implementation of <see cref="T:System.Security.Cryptography.RSA" />.</summary><returns>The name of the signature algorithm.</returns>
        public override string SignatureAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the key should be persisted in the computer's key store instead of the user profile store.</summary><returns>true if the key should be persisted in the computer key store; otherwise, false.</returns>
        public static bool UseMachineKeyStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the key should be persisted in the cryptographic service provider (CSP).</summary><returns>true if the key should be persisted in the CSP; otherwise, false.</returns>
        public bool PersistKeyInCsp
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public RSACryptoServiceProvider()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size.</summary><param name="dwKeySize">The size of the key to use in bits. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception>
        [SecuritySafeCriticalAttribute()]
        public RSACryptoServiceProvider(int dwKeySize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified parameters.</summary><param name="parameters">The parameters to be passed to the cryptographic service provider (CSP). </param><exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired. </exception>
        [SecuritySafeCriticalAttribute()]
        public RSACryptoServiceProvider(CspParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size and parameters.</summary><param name="dwKeySize">The size of the key to use in bits. </param><param name="parameters">The parameters to be passed to the cryptographic service provider (CSP). </param><exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.-or- The key cannot be created. </exception>
        [SecuritySafeCriticalAttribute()]
        public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports the <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary><returns>The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</returns><param name="includePrivateParameters">true to include private parameters; otherwise, false. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override RSAParameters ExportParameters(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports a blob containing the key information associated with an <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object.  </summary><returns>A byte array containing the key information associated with an <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object.</returns><param name="includePrivateParameters">true to include the private key; otherwise, false.</param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public byte[] ExportCspBlob(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary><param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="parameters" /> parameter has missing fields. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override void ImportParameters(RSAParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Imports a blob that represents RSA key information.  </summary><param name="keyBlob">A byte array that represents an RSA key blob.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public void ImportCspBlob(byte[] keyBlob)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the hash value of the specified input stream using the specified hash algorithm, and signs the resulting hash value.</summary><returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified data.</returns><param name="inputStream">The input data for which to compute the hash. </param><param name="halg">The hash algorithm to use to create the hash value. </param><exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignData(Stream inputStream, object halg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the hash value of the specified byte array using the specified hash algorithm, and signs the resulting hash value.</summary><returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified data.</returns><param name="buffer">The input data for which to compute the hash. </param><param name="halg">The hash algorithm to use to create the hash value. </param><exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignData(byte[] buffer, object halg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the hash value of a subset of the specified byte array using the specified hash algorithm, and signs the resulting hash value.</summary><returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified data.</returns><param name="buffer">The input data for which to compute the hash. </param><param name="offset">The offset into the array from which to begin using data. </param><param name="count">The number of bytes in the array to use as data. </param><param name="halg">The hash algorithm to use to create the hash value. </param><exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignData(byte[] buffer, int offset, int count, object halg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the provided public key and comparing it to the hash value of the provided data.</summary><returns>true if the signature is valid; otherwise, false.</returns><param name="buffer">The data that was signed. </param><param name="halg">The name of the hash algorithm used to create the hash value of the data. </param><param name="signature">The signature data to be verified. </param><exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public bool VerifyData(byte[] buffer, object halg, byte[] signature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the signature for the specified hash value by encrypting it with the private key.</summary><returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified hash value.</returns><param name="rgbHash">The hash value of the data to be signed. </param><param name="str">The hash algorithm identifier (OID) used to create the hash value of the data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- There is no private key. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignHash(byte[] rgbHash, string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the provided public key and comparing it to the provided hash value.</summary><returns>true if the signature is valid; otherwise, false.</returns><param name="rgbHash">The hash value of the signed data. </param><param name="str">The hash algorithm identifier (OID) used to create the hash value of the data. </param><param name="rgbSignature">The signature data to be verified. </param><exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is null.-or- The <paramref name="rgbSignature" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The signature cannot be verified. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encrypts data with the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary><returns>The encrypted data.</returns><param name="rgb">The data to be encrypted. </param><param name="fOAEP">true to perform direct <see cref="T:System.Security.Cryptography.RSA" /> encryption using OAEP padding (only available on a computer running Microsoft Windows XP or later); otherwise, false to use PKCS#1 v1.5 padding. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The length of the <paramref name="rgb" /> parameter is greater than the maximum allowed length.-or- The <paramref name="fOAEP" /> parameter is true and OAEP padding is not supported. </exception><exception cref="T:System.ArgumentNullException"><paramref name="rgb " />is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public byte[] Encrypt(byte[] rgb, bool fOAEP)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decrypts data with the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary><returns>The decrypted data, which is the original plain text before encryption.</returns><param name="rgb">The data to be decrypted. </param><param name="fOAEP">true to perform direct <see cref="T:System.Security.Cryptography.RSA" /> decryption using OAEP padding (only available on a computer running Microsoft Windows XP or later); otherwise, false to use PKCS#1 v1.5 padding. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="fOAEP" /> parameter is true and the length of the <paramref name="rgb" /> parameter is greater than <see cref="P:System.Security.Cryptography.RSACryptoServiceProvider.KeySize" />.-or- The <paramref name="fOAEP" /> parameter is true and OAEP is not supported. -or- The key does not match the encrypted data. However, the exception wording may not be accurate. For example, it may say Not enough storage is available to process this command.</exception><exception cref="T:System.ArgumentNullException"><paramref name="rgb " />is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public byte[] Decrypt(byte[] rgb, bool fOAEP)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>This method is not supported in the current version.</summary><returns>The decrypted data, which is the original plain text before encryption.</returns><param name="rgb">The data to be decrypted. </param><exception cref="T:System.NotSupportedException">This method is not supported in the current version. </exception>
        public override byte[] DecryptValue(byte[] rgb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>This method is not supported in the current version.</summary><returns>The encrypted data.</returns><param name="rgb">The data to be encrypted. </param><exception cref="T:System.NotSupportedException">This method is not supported in the current version. </exception>
        public override byte[] EncryptValue(byte[] rgb)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
