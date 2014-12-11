using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Determines the set of valid key sizes for the symmetric cryptographic algorithms.</summary>
    [ComVisibleAttribute(true)]
    public sealed class KeySizes
    {
    
        /// <summary>Specifies the minimum key size in bits.</summary><returns>The minimum key size in bits.</returns>
        public int MinSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Specifies the maximum key size in bits.</summary><returns>The maximum key size in bits.</returns>
        public int MaxSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Specifies the interval between valid key sizes in bits.</summary><returns>The interval between valid key sizes in bits.</returns>
        public int SkipSize
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.KeySizes" /> class with the specified key values.</summary><param name="minSize">The minimum valid key size. </param><param name="maxSize">The maximum valid key size. </param><param name="skipSize">The interval between valid key sizes. </param>
        public KeySizes(int minSize, int maxSize, int skipSize)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
