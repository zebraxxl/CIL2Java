using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Defines a wrapper object to access the cryptographic service provider (CSP) version of the <see cref="T:System.Security.Cryptography.TripleDES" /> algorithm. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class TripleDESCryptoServiceProvider : TripleDES
    {
        [SecuritySafeCriticalAttribute()]
        public TripleDESCryptoServiceProvider()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a symmetric <see cref="T:System.Security.Cryptography.TripleDES" /> encryptor object with the specified key (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary><returns>A symmetric <see cref="T:System.Security.Cryptography.TripleDES" /> encryptor object.</returns><param name="rgbKey">The secret key to use for the symmetric algorithm. </param><param name="rgbIV">The initialization vector to use for the symmetric algorithm. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.-or-The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> and the value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> property is not 8.-or-An invalid key size was used.-or-The algorithm key size was not available.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a symmetric <see cref="T:System.Security.Cryptography.TripleDES" /> decryptor object with the specified key (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) and initialization vector (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary><returns>A symmetric <see cref="T:System.Security.Cryptography.TripleDES" /> decryptor object.</returns><param name="rgbKey">The secret key to use for the symmetric algorithm. </param><param name="rgbIV">The initialization vector to use for the symmetric algorithm. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.-or-The value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> property is <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> and the value of the <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> property is not 8.-or-An invalid key size was used.-or-The algorithm key size was not available.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GenerateKey()
        {
             throw new NotImplementedException();
        }
        
        
        public override void GenerateIV()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
