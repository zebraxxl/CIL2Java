using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes a Hash-based Message Authentication Code (HMAC) using the <see cref="T:System.Security.Cryptography.SHA1" /> hash function. </summary>
    [ComVisibleAttribute(true)]
    public class HMACSHA1 : HMAC
    {
        public HMACSHA1()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA1" /> class with the specified key data.</summary><param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACSHA1" /> encryption. The key can be any length, but if it is more than 64 bytes long it is hashed (using SHA-1) to derive a 64-byte key. Therefore, the recommended size of the secret key is 64 bytes. </param><exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is null. </exception>
        public HMACSHA1(byte[] key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA1" /> class with the specified key data and a value that specifies whether to use the managed version of the SHA1 algorithm.</summary><param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACSHA1" /> encryption. The key can be any length, but if it is more than 64 bytes long, it is hashed (using SHA-1) to derive a 64-byte key. Therefore, the recommended size of the secret key is 64 bytes.</param><param name="useManagedSha1">true to use the managed implementation of the SHA1 algorithm (the <see cref="T:System.Security.Cryptography.SHA1Managed" /> class); false to use the unmanaged implementation (the <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />  class).   </param>
        public HMACSHA1(byte[] key, bool useManagedSha1)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
