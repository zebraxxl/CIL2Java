using System.Runtime.InteropServices;
using System.Security;

namespace System.Text
{
    /// <summary>Converts a sequence of encoded bytes into a set of characters.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class Decoder
    {
    
        /// <summary>Gets or sets a <see cref="T:System.Text.DecoderFallback" /> object for the current <see cref="T:System.Text.Decoder" /> object.</summary><returns>A <see cref="T:System.Text.DecoderFallback" /> object.</returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null (Nothing).</exception><exception cref="T:System.ArgumentException">A new value cannot be assigned in a set operation because the current <see cref="T:System.Text.DecoderFallbackBuffer" /> object contains data that has not been decoded yet. </exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public DecoderFallback Fallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Text.DecoderFallbackBuffer" /> object associated with the current <see cref="T:System.Text.Decoder" /> object.</summary><returns>A <see cref="T:System.Text.DecoderFallbackBuffer" /> object.</returns><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public DecoderFallbackBuffer FallbackBuffer
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected Decoder()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary><returns>The number of characters produced by decoding the specified sequence of bytes and any bytes in the internal buffer.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Decoder.Fallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        
        
        /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array. A parameter indicates whether to clear the internal state of the decoder after the calculation.</summary><returns>The number of characters produced by decoding the specified sequence of bytes and any bytes in the internal buffer.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="index">The index of the first byte to decode. </param><param name="count">The number of bytes to decode. </param><param name="flush">true to simulate clearing the internal state of the encoder after the calculation; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Decoder.Fallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer. A parameter indicates whether to clear the internal state of the decoder after the calculation.</summary><returns>The number of characters produced by decoding the specified sequence of bytes and any bytes in the internal buffer.</returns><param name="bytes">A pointer to the first byte to decode. </param><param name="count">The number of bytes to decode. </param><param name="flush">true to simulate clearing the internal state of the encoder after the calculation; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing in Visual Basic .NET). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Decoder.Fallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array and any bytes in the internal buffer into the specified character array.</summary><returns>The actual number of characters written into <paramref name="chars" />.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="byteIndex">The index of the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">The character array to contain the resulting set of characters. </param><param name="charIndex">The index at which to start writing the resulting set of characters. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing).-or- <paramref name="chars" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception><exception cref="T:System.ArgumentException"><paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Decoder.Fallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array and any bytes in the internal buffer into the specified character array. A parameter indicates whether to clear the internal state of the decoder after the conversion.</summary><returns>The actual number of characters written into the <paramref name="chars" /> parameter.</returns><param name="bytes">The byte array containing the sequence of bytes to decode. </param><param name="byteIndex">The index of the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">The character array to contain the resulting set of characters. </param><param name="charIndex">The index at which to start writing the resulting set of characters. </param><param name="flush">true to clear the internal state of the decoder after the conversion; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing).-or- <paramref name="chars" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception><exception cref="T:System.ArgumentException"><paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Decoder.Fallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, decodes a sequence of bytes starting at the specified byte pointer and any bytes in the internal buffer into a set of characters that are stored starting at the specified character pointer. A parameter indicates whether to clear the internal state of the decoder after the conversion.</summary><returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns><param name="bytes">A pointer to the first byte to decode. </param><param name="byteCount">The number of bytes to decode. </param><param name="chars">A pointer to the location at which to start writing the resulting set of characters. </param><param name="charCount">The maximum number of characters to write. </param><param name="flush">true to clear the internal state of the decoder after the conversion; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null (Nothing).-or- <paramref name="chars" /> is null (Nothing). </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="charCount" /> is less than the resulting number of characters. </exception><exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)-and-<see cref="P:System.Text.Decoder.Fallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
