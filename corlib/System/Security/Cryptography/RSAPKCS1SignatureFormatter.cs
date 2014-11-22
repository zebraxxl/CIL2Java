using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Creates an <see cref="T:System.Security.Cryptography.RSA" /> PKCS #1 version 1.5 signature.</summary>
    [ComVisibleAttribute(true)]
    public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
    {
    
        public RSAPKCS1SignatureFormatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureFormatter" /> class with the specified key.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null.</exception>
        public RSAPKCS1SignatureFormatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the private key to use for creating the signature.</summary><param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null.</exception>
        public override void SetKey(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the hash algorithm to use for creating the signature.</summary><param name="strName">The name of the hash algorithm to use for creating the signature. </param>
        public override void SetHashAlgorithm(string strName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates the <see cref="T:System.Security.Cryptography.RSA" /> PKCS #1 signature for the specified data.</summary><returns>The digital signature for <paramref name="rgbHash" />.</returns><param name="rgbHash">The data to be signed. </param><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is null.-or- The hash algorithm is null. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override byte[] CreateSignature(byte[] rgbHash)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
