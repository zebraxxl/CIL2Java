
namespace System.Text
{
    /// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> when an encoded input byte sequence cannot be converted to a decoded output character. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
    {
        /// <summary>Gets the number of characters in the current <see cref="T:System.Text.DecoderExceptionFallbackBuffer" /> object that remain to be processed.</summary><returns>The return value is always zero. A return value is defined, although it is unchanging, because this method implements an abstract method.</returns><filterpriority>1</filterpriority>
        public override int Remaining
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> when the input byte sequence cannot be decoded. The nominal return value is not used. </summary><returns>None. No value is returned because the <see cref="M:System.Text.DecoderExceptionFallbackBuffer.Fallback(System.Byte[],System.Int32)" /> method always throws an exception. The nominal return value is true. A return value is defined, although it is unchanging, because this method implements an abstract method.</returns><param name="bytesUnknown">An input array of bytes.</param><param name="index">The index position of a byte in the input.</param><exception cref="T:System.Text.DecoderFallbackException">This method always throws an exception that reports the value and index position of the input byte that cannot be decoded. </exception><filterpriority>1</filterpriority>
        public override bool Fallback(byte[] bytesUnknown, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public override char GetNextChar()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool MovePrevious()
        {
             throw new NotImplementedException();
        }
        
        
        public DecoderExceptionFallbackBuffer()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
