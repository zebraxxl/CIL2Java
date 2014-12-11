using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes a Hash-based Message Authentication Code (HMAC) by using the <see cref="T:System.Security.Cryptography.RIPEMD160" /> hash function.</summary>
    [ComVisibleAttribute(true)]
    public class HMACRIPEMD160 : HMAC
    {
        public HMACRIPEMD160()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> class with the specified key data.</summary><param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> encryption. The key can be any length, but if it is more than 64 bytes long it is hashed (using SHA-1) to derive a 64-byte key. Therefore, the recommended size of the secret key is 64 bytes.</param><exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is null. </exception>
        public HMACRIPEMD160(byte[] key)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
