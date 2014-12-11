using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Represents the abstract class from which all implementations of Hash-based Message Authentication Code (HMAC) must derive.</summary>
    [ComVisibleAttribute(true)]
    public abstract class HMAC : KeyedHashAlgorithm
    {
    
        /// <summary>Gets or sets the block size to use in the hash value.</summary><returns>The block size to use in the hash value.</returns>
        protected int BlockSizeValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key to use in the hash algorithm.</summary><returns>The key to use in the hash algorithm.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">An attempt is made to change the <see cref="P:System.Security.Cryptography.HMAC.Key" /> property after hashing has begun. </exception>
        public override byte[] Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the hash algorithm to use for hashing.</summary><returns>The name of the hash algorithm.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The current hash algorithm cannot be changed.</exception>
        public string HashName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        public static new HMAC Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the specified implementation of a Hash-based Message Authentication Code (HMAC).</summary><returns>A new instance of the specified HMAC implementation.</returns><param name="algorithmName">The HMAC implementation to use. The following table shows the valid values for the <paramref name="algorithmName" /> parameter and the algorithms they map to.Parameter valueImplements System.Security.Cryptography.HMAC<see cref="T:System.Security.Cryptography.HMACSHA1" />System.Security.Cryptography.KeyedHashAlgorithm<see cref="T:System.Security.Cryptography.HMACSHA1" />HMACMD5<see cref="T:System.Security.Cryptography.HMACMD5" />System.Security.Cryptography.HMACMD5<see cref="T:System.Security.Cryptography.HMACMD5" />HMACRIPEMD160<see cref="T:System.Security.Cryptography.HMACRIPEMD160" />System.Security.Cryptography.HMACRIPEMD160<see cref="T:System.Security.Cryptography.HMACRIPEMD160" />HMACSHA1<see cref="T:System.Security.Cryptography.HMACSHA1" />System.Security.Cryptography.HMACSHA1<see cref="T:System.Security.Cryptography.HMACSHA1" />HMACSHA256<see cref="T:System.Security.Cryptography.HMACSHA256" />System.Security.Cryptography.HMACSHA256<see cref="T:System.Security.Cryptography.HMACSHA256" />HMACSHA384<see cref="T:System.Security.Cryptography.HMACSHA384" />System.Security.Cryptography.HMACSHA384<see cref="T:System.Security.Cryptography.HMACSHA384" />HMACSHA512<see cref="T:System.Security.Cryptography.HMACSHA512" />System.Security.Cryptography.HMACSHA512<see cref="T:System.Security.Cryptography.HMACSHA512" />MACTripleDES<see cref="T:System.Security.Cryptography.MACTripleDES" />System.Security.Cryptography.MACTripleDES<see cref="T:System.Security.Cryptography.MACTripleDES" /></param>
        public static new HMAC Create(string algorithmName)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Initialize()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, routes data written to the object into the default <see cref="T:System.Security.Cryptography.HMAC" /> hash algorithm for computing the hash value.</summary><param name="rgb">The input data. </param><param name="ib">The offset into the byte array from which to begin using data. </param><param name="cb">The number of bytes in the array to use as data. </param>
        protected override void HashCore(byte[] rgb, int ib, int cb)
        {
             throw new NotImplementedException();
        }
        
        
        protected override byte[] HashFinal()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HMAC" /> class when a key change is legitimate and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected HMAC()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
