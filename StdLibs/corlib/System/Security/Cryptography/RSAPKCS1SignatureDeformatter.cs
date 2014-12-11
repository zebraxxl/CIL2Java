using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Verifies an <see cref="T:System.Security.Cryptography.RSA" /> PKCS #1 version 1.5 signature.</summary>
    [ComVisibleAttribute(true)]
    public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
    {
    
        public RSAPKCS1SignatureDeformatter()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1SignatureDeformatter" /> class with the specified key.</summary><param name="key">The instance of <see cref="T:System.Security.Cryptography.RSA" /> that holds the public key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the public key to use for verifying the signature.</summary><param name="key">The instance of <see cref="T:System.Security.Cryptography.RSA" /> that holds the public key. </param><exception cref="T:System.ArgumentNullException"><paramref name="key " />is null.</exception>
        public override void SetKey(AsymmetricAlgorithm key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the hash algorithm to use for verifying the signature.</summary><param name="strName">The name of the hash algorithm to use for verifying the signature. </param>
        public override void SetHashAlgorithm(string strName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Verifies the <see cref="T:System.Security.Cryptography.RSA" /> PKCS#1 signature for the specified data.</summary><returns>true if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, false.</returns><param name="rgbHash">The data signed with <paramref name="rgbSignature" />. </param><param name="rgbSignature">The signature to be verified for <paramref name="rgbHash" />. </param><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is null.-or- The hash algorithm is null. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is null.-or- The <paramref name="rgbSignature" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
