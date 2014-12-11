using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes a Message Authentication Code (MAC) using <see cref="T:System.Security.Cryptography.TripleDES" /> for the input data <see cref="T:System.Security.Cryptography.CryptoStream" />.</summary>
    [ComVisibleAttribute(true)]
    public class MACTripleDES : KeyedHashAlgorithm
    {
    
        /// <summary>Gets or sets the padding mode used in the hashing algorithm.</summary><returns>The padding mode used in the hashing algorithm.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The property cannot be set because the padding mode is invalid.</exception>
        [ComVisibleAttribute(false)]
        public PaddingMode Padding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public MACTripleDES()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.MACTripleDES" /> class with the specified key data.</summary><param name="rgbKey">The secret key for <see cref="T:System.Security.Cryptography.MACTripleDES" /> encryption. </param><exception cref="T:System.ArgumentNullException">The <paramref name="rgbKey" /> parameter is null. </exception>
        public MACTripleDES(byte[] rgbKey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.MACTripleDES" /> class with the specified key data and using the specified implementation of <see cref="T:System.Security.Cryptography.TripleDES" />.</summary><param name="strTripleDES">The name of the <see cref="T:System.Security.Cryptography.TripleDES" /> implementation to use. </param><param name="rgbKey">The secret key for <see cref="T:System.Security.Cryptography.MACTripleDES" /> encryption. </param><exception cref="T:System.ArgumentNullException">The <paramref name="rgbKey" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The <paramref name="strTripleDES" /> parameter is not a valid name of a <see cref="T:System.Security.Cryptography.TripleDES" /> implementation. </exception>
        public MACTripleDES(string strTripleDES, byte[] rgbKey)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Initialize()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Routes data written to the object into the <see cref="T:System.Security.Cryptography.TripleDES" /> encryptor for computing the Message Authentication Code (MAC).</summary><param name="rgbData">The input data. </param><param name="ibStart">The offset into the byte array from which to begin using data. </param><param name="cbSize">The number of bytes in the array to use as data. </param>
        protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
        {
             throw new NotImplementedException();
        }
        
        
        protected override byte[] HashFinal()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.MACTripleDES" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
