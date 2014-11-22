using System.Runtime.InteropServices;
using System.Security;

namespace System.Text
{
    /// <summary>Converts a set of characters into a sequence of bytes.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class Encoder
    {
    
        /// <summary>Gets or sets a <see cref="T:System.Text.EncoderFallback" /> object for the current <see cref="T:System.Text.Encoder" /> object.</summary><returns>A <see cref="T:System.Text.EncoderFallback" /> object.</returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null (Nothing).</exception><exception cref="T:System.ArgumentException">A new value cannot be assigned in a set operation because the current <see cref="T:System.Text.EncoderFallbackBuffer" /> object contains data that has not been encoded yet. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public EncoderFallback Fallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Text.EncoderFallbackBuffer" /> object associated with the current <see cref="T:System.Text.Encoder" /> object.</summary><returns>A <see cref="T:System.Text.EncoderFallbackBuffer" /> object.</returns><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public EncoderFallbackBuffer FallbackBuffer
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected Encoder()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array. A parameter indicates whether to clear the internal state of the encoder after the calculation.</summary><returns>The number of bytes produced by encoding the specified characters and any characters in the internal buffer.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="index">The index of the first character to encode. </param><param name="count">The number of characters to encode. </param><param name="flush">true to simulate clearing the internal state of the encoder after the calculation; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        public abstract int GetByteCount(char[] chars, int index, int count, bool flush);
        
        
        /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer. A parameter indicates whether to clear the internal state of the encoder after the calculation.</summary><returns>The number of bytes produced by encoding the specified characters and any characters in the internal buffer.</returns><param name="chars">A pointer to the first character to encode. </param><param name="count">The number of characters to encode. </param><param name="flush">true to simulate clearing the internal state of the encoder after the calculation; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing in Visual Basic .NET). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, encodes a set of characters from the specified character array and any characters in the internal buffer into the specified byte array. A parameter indicates whether to clear the internal state of the encoder after the conversion.</summary><returns>The actual number of bytes written into <paramref name="bytes" />.</returns><param name="chars">The character array containing the set of characters to encode. </param><param name="charIndex">The index of the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">The byte array to contain the resulting sequence of bytes. </param><param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param><param name="flush">true to clear the internal state of the encoder after the conversion; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing).-or- <paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception><exception cref="T:System.ArgumentException"><paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);
        
        
        /// <summary>When overridden in a derived class, encodes a set of characters starting at the specified character pointer and any characters in the internal buffer into a sequence of bytes that are stored starting at the specified byte pointer. A parameter indicates whether to clear the internal state of the encoder after the conversion.</summary><returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns><param name="chars">A pointer to the first character to encode. </param><param name="charCount">The number of characters to encode. </param><param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes. </param><param name="byteCount">The maximum number of bytes to write. </param><param name="flush">true to clear the internal state of the encoder after the conversion; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="chars" /> is null (Nothing).-or- <paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="byteCount" /> is less than the resulting number of bytes. </exception><exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, ref int charsUsed, ref int bytesUsed, ref bool completed)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, ref int charsUsed, ref int bytesUsed, ref bool completed)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
