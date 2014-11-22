using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Performs a cryptographic transformation of data using the Rijndael algorithm. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class RijndaelManagedTransform : ICryptoTransform
    {
    
        /// <summary>Gets the block size.</summary><returns>The size of the data blocks in bytes.</returns>
        public int BlockSizeValue
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the input block size.</summary><returns>The size of the input data blocks in bytes.</returns>
        public int InputBlockSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the output block size.</summary><returns>The size of the output data blocks in bytes.</returns>
        public int OutputBlockSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether multiple blocks can be transformed.</summary><returns>true if multiple blocks can be transformed; otherwise, false.</returns>
        public bool CanTransformMultipleBlocks
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current transform can be reused.</summary><returns>Always true.</returns>
        public bool CanReuseTransform
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the transformation for the specified region of the input byte array and copies the resulting transformation to the specified region of the output byte array.</summary><returns>The number of bytes written.</returns><param name="inputBuffer">The input to perform the operation on. </param><param name="inputOffset">The offset into the input byte array to begin using data from. </param><param name="inputCount">The number of bytes in the input byte array to use as data. </param><param name="outputBuffer">The output to write the data to. </param><param name="outputOffset">The offset into the output byte array to begin writing data from. </param><exception cref="T:System.ArgumentNullException">The <paramref name="inputBuffer" /> parameter is null.-or- The <paramref name="outputBuffer" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The length of the input buffer is less than the sum of the input offset and the input count. -or-The value of the <paramref name="inputCount" /> parameter is less than or equal to 0.-or-The value of the <paramref name="inputCount" /> parameter is greater than the length of the <paramref name="inputBuffer" /> parameter.-or-The length of the <paramref name="inputCount" /> parameter is not evenly devisable by input block size. </exception><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="inputOffset" /> parameter is negative.</exception>
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Computes the transformation for the specified region of the specified byte array.</summary><returns>The computed transformation.</returns><param name="inputBuffer">The input to perform the operation on.</param><param name="inputOffset">The offset into the byte array to begin using data from.</param><param name="inputCount">The number of bytes in the byte array to use as data.</param><exception cref="T:System.ArgumentNullException">The <paramref name="inputBuffer" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The value of the <paramref name="inputCount" /> parameter is less than 0.-or-The value of the <paramref name="inputCount" /> parameter is grater than the length of <paramref name="inputBuffer" /> parameter.</exception><exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="inputOffset" /> parameter is negative.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">The length of the <paramref name="inputCount" /> parameter is not evenly devisable by input block size.</exception>
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
