using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA256" /> hash for the input data using the managed library. </summary>
    [ComVisibleAttribute(true)]
    public class SHA256Managed : SHA256
    {
    
        public SHA256Managed()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Initialize()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, routes data written to the object into the <see cref="T:System.Security.Cryptography.SHA256" /> hash algorithm for computing the hash.</summary><param name="rgb">The input data. </param><param name="ibStart">The offset into the byte array from which to begin using data. </param><param name="cbSize">The number of bytes in the array to use as data. </param>
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
        {
             throw new NotImplementedException();
        }
        
        
        protected override byte[] HashFinal()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
