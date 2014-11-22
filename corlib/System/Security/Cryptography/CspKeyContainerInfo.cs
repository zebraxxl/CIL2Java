using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Provides additional information about a cryptographic key pair. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class CspKeyContainerInfo
    {
    
        /// <summary>Gets a value indicating whether a key is from a machine key set.</summary><returns>true if the key is from the machine key set; otherwise, false.</returns>
        public bool MachineKeyStore
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the provider name of a key.</summary><returns>The provider name.</returns>
        public string ProviderName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the provider type of a key.</summary><returns>The provider type. The default is 1.</returns>
        public int ProviderType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a key container name.</summary><returns>The key container name.</returns>
        public string KeyContainerName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a unique key container name.</summary><returns>The unique key container name.</returns><exception cref="T:System.NotSupportedException">The key type is not supported.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider cannot be found.-or-The key container was not found.</exception>
        public string UniqueKeyContainerName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that describes whether an asymmetric key was created as a signature key or an exchange key.</summary><returns>One of the <see cref="T:System.Security.Cryptography.KeyNumber" /> values that describes whether an asymmetric key was created as a signature key or an exchange key.</returns>
        public KeyNumber KeyNumber
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key can be exported from a key container.</summary><returns>true if the key can be exported; otherwise, false.</returns><exception cref="T:System.NotSupportedException">The key type is not supported.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider cannot be found.-or-The key container was not found.</exception>
        public bool Exportable
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key is a hardware key.</summary><returns>true if the key is a hardware key; otherwise, false.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider cannot be found.</exception>
        public bool HardwareDevice
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key can be removed from a key container.</summary><returns>true if the key is removable; otherwise, false.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) was not found.</exception>
        public bool Removable
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key in a key container is accessible.</summary><returns>true if the key is accessible; otherwise, false.</returns><exception cref="T:System.NotSupportedException">The key type is not supported.</exception>
        public bool Accessible
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key pair is protected.</summary><returns>true if the key pair is protected; otherwise, false.</returns><exception cref="T:System.NotSupportedException">The key type is not supported.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider cannot be found.-or-The key container was not found.</exception>
        public bool Protected
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object that represents access rights and audit rules for a container. </summary><returns>A <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object that represents access rights and audit rules for a container.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The key type is not supported.</exception><exception cref="T:System.NotSupportedException">The cryptographic service provider cannot be found.-or-The key container was not found.</exception>
        public CryptoKeySecurity CryptoKeySecurity
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a key container was randomly generated by a managed cryptography class.</summary><returns>true if the key container was randomly generated; otherwise, false.</returns>
        public bool RandomlyGenerated
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> class using the specified parameters.</summary><param name="parameters">A <see cref="T:System.Security.Cryptography.CspParameters" /> object that provides information about the key.</param>
        [SecuritySafeCriticalAttribute()]
        public CspKeyContainerInfo(CspParameters parameters)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
