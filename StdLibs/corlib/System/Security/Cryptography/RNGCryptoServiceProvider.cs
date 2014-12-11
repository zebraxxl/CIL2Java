using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Implements a cryptographic Random Number Generator (RNG) using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
    {
    
        public RNGCryptoServiceProvider()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.</summary><param name="str">The string input. This parameter is ignored.</param>
        public RNGCryptoServiceProvider(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class.</summary><param name="rgb">A byte array. This value is ignored.</param>
        public RNGCryptoServiceProvider(byte[] rgb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RNGCryptoServiceProvider" /> class with the specified parameters.</summary><param name="cspParams">The parameters to pass to the cryptographic service provider (CSP). </param>
        [SecuritySafeCriticalAttribute()]
        public RNGCryptoServiceProvider(CspParameters cspParams)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Fills an array of bytes with a cryptographically strong sequence of random values.</summary><param name="data">The array to fill with a cryptographically strong sequence of random values. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception><exception cref="T:System.ArgumentNullException"><paramref name="data" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public override void GetBytes(byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Fills an array of bytes with a cryptographically strong sequence of random nonzero values.</summary><param name="data">The array to fill with a cryptographically strong sequence of random nonzero values. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception><exception cref="T:System.ArgumentNullException"><paramref name="data" /> is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public override void GetNonZeroBytes(byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
