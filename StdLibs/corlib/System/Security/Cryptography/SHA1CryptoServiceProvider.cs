using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash value for the input data using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited. </summary>
    [ComVisibleAttribute(true)]
    public sealed class SHA1CryptoServiceProvider : SHA1
    {
    
        [SecuritySafeCriticalAttribute()]
        public SHA1CryptoServiceProvider()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override void Initialize()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override byte[] HashFinal()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
