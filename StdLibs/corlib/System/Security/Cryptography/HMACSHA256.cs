using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes a Hash-based Message Authentication Code (HMAC) by using the <see cref="T:System.Security.Cryptography.SHA256" /> hash function.</summary>
    [ComVisibleAttribute(true)]
    public class HMACSHA256 : HMAC
    {
    
        public HMACSHA256()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA256" /> class with the specified key data.</summary><param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACSHA256" /> encryption. The key can be any length. However, the recommended size is 64 bytes. If the key is more than 64 bytes long, it is hashed (using SHA-256) to derive a 64-byte key. If it is less than 64 bytes long, it is padded to 64 bytes. </param><exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is null. </exception>
        public HMACSHA256(byte[] key)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
