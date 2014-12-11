using System.Runtime.InteropServices;
using System.Security;
using System.IO;

namespace System.Security.Cryptography
{
    /// <summary>Defines a wrapper object to access the cryptographic service provider (CSP) implementation of the <see cref="T:System.Security.Cryptography.DSA" /> algorithm. This class cannot be inherited. </summary>
    [ComVisibleAttribute(true)]
    public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
    {
    
        /// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key.</summary><returns>true if the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key; otherwise, false.</returns>
        [ComVisibleAttribute(false)]
        public bool PublicOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.  </summary><returns>A <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.</returns>
        [ComVisibleAttribute(false)]
        public CspKeyContainerInfo CspKeyContainerInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the size of the key used by the asymmetric algorithm in bits.</summary><returns>The size of the key used by the asymmetric algorithm.</returns>
        public override int KeySize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the key exchange algorithm.</summary><returns>The name of the key exchange algorithm.</returns>
        public override string KeyExchangeAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the signature algorithm.</summary><returns>The name of the signature algorithm.</returns>
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
    
    
        public DSACryptoServiceProvider()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size.</summary><param name="dwKeySize">The size of the key for the asymmetric algorithm in bits. </param>
        public DSACryptoServiceProvider(int dwKeySize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified parameters for the cryptographic service provider (CSP).</summary><param name="parameters">The parameters for the CSP. </param>
        public DSACryptoServiceProvider(CspParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size and parameters for the cryptographic service provider (CSP).</summary><param name="dwKeySize">The size of the key for the cryptographic algorithm in bits. </param><param name="parameters">The parameters for the CSP. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.-or- The key cannot be created. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dwKeySize" /> is out of range.</exception>
        [SecuritySafeCriticalAttribute()]
        public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports the <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary><returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns><param name="includePrivateParameters">true to include private parameters; otherwise, false. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override DSAParameters ExportParameters(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports a blob containing the key information associated with a <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object.  </summary><returns>A byte array containing the key information associated with a <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object.</returns><param name="includePrivateParameters">true to include the private key; otherwise, false.</param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public byte[] ExportCspBlob(bool includePrivateParameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Imports the specified <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary><param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.DSA" />. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="parameters" /> parameter has missing fields. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override void ImportParameters(DSAParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Imports a blob that represents DSA key information.</summary><param name="keyBlob">A byte array that represents a DSA key blob.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public void ImportCspBlob(byte[] keyBlob)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the hash value of the specified input stream and signs the resulting hash value.</summary><returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</returns><param name="inputStream">The input data for which to compute the hash. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignData(Stream inputStream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the hash value of the specified byte array and signs the resulting hash value.</summary><returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</returns><param name="buffer">The input data for which to compute the hash. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignData(byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Signs a byte array from the specified start point to the specified end point.</summary><returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</returns><param name="buffer">The input data to sign. </param><param name="offset">The offset into the array from which to begin using data. </param><param name="count">The number of bytes in the array to use as data. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public byte[] SignData(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Verifies the specified signature data by comparing it to the signature computed for the specified data.</summary><returns>true if the signature verifies as valid; otherwise, false.</returns><param name="rgbData">The data that was signed. </param><param name="rgbSignature">The signature data to be verified. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public bool VerifyData(byte[] rgbData, byte[] rgbSignature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary><returns>The digital signature for the specified data.</returns><param name="rgbHash">The data to be signed. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override byte[] CreateSignature(byte[] rgbHash)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Verifies the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary><returns>true if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, false.</returns><param name="rgbHash">The data signed with <paramref name="rgbSignature" />. </param><param name="rgbSignature">The signature to be verified for <paramref name="rgbData" />. </param><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the signature for the specified hash value by encrypting it with the private key.</summary><returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified hash value.</returns><param name="rgbHash">The hash value of the data to be signed. </param><param name="str">The name of the hash algorithm used to create the hash value of the data. </param><exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- There is no private key. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public byte[] SignHash(byte[] rgbHash, string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Verifies the specified signature data by comparing it to the signature computed for the specified hash value.</summary><returns>true if the signature verifies as valid; otherwise, false.</returns><param name="rgbHash">The hash value of the data to be signed. </param><param name="str">The name of the hash algorithm used to create the hash value of the data. </param><param name="rgbSignature">The signature data to be verified. </param><exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is null.-or- The <paramref name="rgbSignature" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The signature cannot be verified. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
