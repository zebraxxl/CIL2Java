using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace System.Security.Permissions
{
    /// <summary>Specifies access rights for specific key containers. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class KeyContainerPermissionAccessEntry
    {
    
        /// <summary>Gets or sets the name of the key store.</summary><returns>The name of the key store.</returns><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public string KeyStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the provider name.</summary><returns>The name of the provider.</returns><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public string ProviderName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the provider type.</summary><returns>One of the PROV_ values defined in the Wincrypt.h header file.</returns><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public int ProviderType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key container name.</summary><returns>The name of the key container.</returns><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public string KeyContainerName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key specification.</summary><returns>One of the AT_ values defined in the Wincrypt.h header file.</returns><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public int KeySpec
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key container permissions.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" /> values. The default is <see cref="F:System.Security.Permissions.KeyContainerPermissionFlags.NoFlags" />.</returns>
        public KeyContainerPermissionFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> class, using the specified key container name and access permissions.</summary><param name="keyContainerName">The name of the key container. </param><param name="flags">A bitwise combination of the <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" /> values. </param><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public KeyContainerPermissionAccessEntry(string keyContainerName, KeyContainerPermissionFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> class, using the specified cryptographic service provider (CSP) parameters and access permissions.</summary><param name="parameters">A <see cref="T:System.Security.Cryptography.CspParameters" /> object that contains the cryptographic service provider (CSP) parameters. </param><param name="flags">A bitwise combination of the <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" /> values. </param><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public KeyContainerPermissionAccessEntry(CspParameters parameters, KeyContainerPermissionFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> class with the specified property values.</summary><param name="keyStore">The name of the key store. </param><param name="providerName">The name of the provider. </param><param name="providerType">The type code for the provider. See the <see cref="P:System.Security.Permissions.KeyContainerPermissionAccessEntry.ProviderType" /> property for values. </param><param name="keyContainerName">The name of the key container. </param><param name="keySpec">The key specification. See the <see cref="P:System.Security.Permissions.KeyContainerPermissionAccessEntry.KeySpec" /> property for values. </param><param name="flags">A bitwise combination of the <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" /> values. </param><exception cref="T:System.ArgumentException">The resulting entry would have unrestricted access. </exception>
        public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, KeyContainerPermissionFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object is equal to the current instance.</summary><returns>true if the specified <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> is equal to the current <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object; otherwise, false.</returns><param name="o">The <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object to compare with the currentinstance. </param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
