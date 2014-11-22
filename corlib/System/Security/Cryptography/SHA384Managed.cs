using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Cryptography
{
    /// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA384" /> hash for the input data using the managed library. </summary>
    [ComVisibleAttribute(true)]
    public class SHA384Managed : SHA384
    {
    
        public SHA384Managed()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Initialize()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.SHA384Managed" /> hash algorithm for computing the hash.</summary><param name="rgb">The input data. </param><param name="ibStart">The offset into the byte array from which to begin using data. </param><param name="cbSize">The number of bytes in the array to use as data. </param>
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
