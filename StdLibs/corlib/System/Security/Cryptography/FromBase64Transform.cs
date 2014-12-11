using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Converts a <see cref="T:System.Security.Cryptography.CryptoStream" /> from base 64.</summary>
    [ComVisibleAttribute(true)]
    public class FromBase64Transform : ICryptoTransform
    {
    
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
    
        /// <summary>Gets a value that indicates whether multiple blocks can be transformed.</summary><returns>Always false.</returns>
        public bool CanTransformMultipleBlocks
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current transform can be reused.</summary><returns>Always true.</returns>
        public virtual bool CanReuseTransform
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public FromBase64Transform()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.FromBase64Transform" /> class with the specified transformation mode.</summary><param name="whitespaces">One of the <see cref="T:System.Security.Cryptography.FromBase64Transform" /> values. </param>
        public FromBase64Transform(FromBase64TransformMode whitespaces)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified region of the input byte array from base 64 and copies the result to the specified region of the output byte array.</summary><returns>The number of bytes written.</returns><param name="inputBuffer">The input to compute from base 64. </param><param name="inputOffset">The offset into the input byte array from which to begin using data. </param><param name="inputCount">The number of bytes in the input byte array to use as data. </param><param name="outputBuffer">The output to which to write the result. </param><param name="outputOffset">The offset into the output byte array from which to begin writing data. </param><exception cref="T:System.ObjectDisposedException">The current <see cref="T:System.Security.Cryptography.FromBase64Transform" /> object has already been disposed. </exception><exception cref="T:System.ArgumentException"><paramref name="inputCount" /> uses an invalid value.-or-<paramref name="inputBuffer" /> has an invalid offset length.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="inputOffset" /> is out of range. This parameter requires a non-negative number.</exception><exception cref="T:System.ArgumentNullException"><paramref name="inputBuffer" /> is null.</exception>
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified region of the specified byte array from base 64.</summary><returns>The computed conversion.</returns><param name="inputBuffer">The input to convert from base 64. </param><param name="inputOffset">The offset into the byte array from which to begin using data. </param><param name="inputCount">The number of bytes in the byte array to use as data. </param><exception cref="T:System.ObjectDisposedException">The current <see cref="T:System.Security.Cryptography.FromBase64Transform" /> object has already been disposed. </exception><exception cref="T:System.ArgumentException"><paramref name="inputBuffer" /> has an invalid offset length.-or-<paramref name="inputCount" /> has an invalid value.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="inputOffset" /> is out of range. This parameter requires a non-negative number.</exception><exception cref="T:System.ArgumentNullException"><paramref name="inputBuffer" /> is null.</exception>
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.FromBase64Transform" /> and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        ~FromBase64Transform()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
