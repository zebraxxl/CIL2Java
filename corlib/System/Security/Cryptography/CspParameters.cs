using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Contains parameters that are passed to the cryptographic service provider (CSP) that performs cryptographic computations. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class CspParameters
    {
        /// <summary>Represents the provider type code for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
        public int ProviderType;
        /// <summary>Represents the provider name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
        public string ProviderName;
        /// <summary>Represents the key container name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
        public string KeyContainerName;
        /// <summary>Specifies whether an asymmetric key is created as a signature key or an exchange key.</summary>
        public int KeyNumber;
    
        /// <summary>Represents the flags for <see cref="T:System.Security.Cryptography.CspParameters" /> that modify the behavior of the cryptographic service provider (CSP).</summary><returns>An enumeration value, or a bitwise combination of enumeration values.</returns><exception cref="T:System.ArgumentException">Value is not a valid enumeration value.</exception>
        public CspProviderFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object that represents access rights and audit rules for a container. </summary><returns>A <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object that represents access rights and audit rules for a container.</returns>
        public CryptoKeySecurity CryptoKeySecurity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a password associated with a smart card key. </summary><returns>A password associated with a smart card key.</returns>
        public SecureString KeyPassword
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a handle to the unmanaged parent window for a smart card password dialog.</summary><returns>A handle to the parent window for a smart card password dialog.</returns>
        public IntPtr ParentWindowHandle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CspParameters()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code.</summary><param name="dwTypeIn">A provider type code that specifies the kind of provider to create. </param>
        public CspParameters(int dwTypeIn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code and name.</summary><param name="dwTypeIn">A provider type code that specifies the kind of provider to create.</param><param name="strProviderNameIn">A provider name. </param>
        public CspParameters(int dwTypeIn, string strProviderNameIn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code and name, and the specified container name.</summary><param name="dwTypeIn">The provider type code that specifies the kind of provider to create.</param><param name="strProviderNameIn">A provider name. </param><param name="strContainerNameIn">A container name. </param>
        public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class using a provider type, a provider name, a container name, access information, and a password associated with a smart card key.</summary><param name="providerType">The provider type code that specifies the kind of provider to create.</param><param name="providerName">A provider name. </param><param name="keyContainerName">A container name. </param><param name="cryptoKeySecurity">An object that represents access rights and audit rules for a container. </param><param name="keyPassword">A password associated with a smart card key.</param>
        public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class using a provider type, a provider name, a container name, access information, and a handle to an unmanaged smart card password dialog. </summary><param name="providerType">The provider type code that specifies the kind of provider to create.</param><param name="providerName">A provider name. </param><param name="keyContainerName">A container name. </param><param name="cryptoKeySecurity">An object that represents access rights and audit rules for the container.</param><param name="parentWindowHandle">A handle to the parent window for a smart card password dialog.</param>
        public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, IntPtr parentWindowHandle)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
