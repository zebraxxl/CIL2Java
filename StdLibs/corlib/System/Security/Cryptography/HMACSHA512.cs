using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Computes a Hash-based Message Authentication Code (HMAC) using the <see cref="T:System.Security.Cryptography.SHA512" /> hash function.</summary>
    [ComVisibleAttribute(true)]
    public class HMACSHA512 : HMAC
    {
    
        /// <summary>Provides a workaround for the .NET Framework 2.0 implementation of the <see cref="T:System.Security.Cryptography.HMACSHA512" /> algorithm, which is inconsistent with the .NET Framework 2.0 Service Pack 1 implementation.</summary><returns>true to enable .NET Framework 2.0 Service Pack 1 applications to interact with .NET Framework 2.0 applications; otherwise, false.</returns>
        public bool ProduceLegacyHmacValues
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HMACSHA512()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.HMACSHA512" /> class with the specified key data.</summary><param name="key">The secret key for <see cref="T:System.Security.Cryptography.HMACSHA512" /> encryption. The key can be any length. However, the recommended size is 128 bytes. If the key is more than 128 bytes long, it is hashed (using SHA-512) to derive a 128-byte key. If it is less than 128 bytes long, it is padded to 128 bytes. </param><exception cref="T:System.ArgumentNullException">The <paramref name="key" /> parameter is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public HMACSHA512(byte[] key)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
