using System.Security;

namespace System.Text
{
    /// <summary>Represents a substitute output string that is emitted when the original input byte sequence cannot be decoded. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
    
        /// <summary>Gets the number of characters in the replacement fallback buffer that remain to be processed.</summary><returns>The number of characters in the replacement fallback buffer that have not yet been processed.</returns><filterpriority>1</filterpriority>
        public override int Remaining
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderReplacementFallbackBuffer" /> class using the value of a <see cref="T:System.Text.DecoderReplacementFallback" /> object.</summary><param name="fallback">A <see cref="T:System.Text.DecoderReplacementFallback" /> object that contains a replacement string. </param>
        public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Prepares the replacement fallback buffer to use the current replacement string.</summary><returns>true if the replacement string is not empty; false if the replacement string is empty.</returns><param name="bytesUnknown">An input byte sequence. This parameter is ignored unless an exception is thrown.</param><param name="index">The index position of the byte in <paramref name="bytesUnknown" />. This parameter is ignored in this operation.</param><exception cref="T:System.ArgumentException">This method is called again before the <see cref="M:System.Text.DecoderReplacementFallbackBuffer.GetNextChar" /> method has read all the characters in the replacement fallback buffer.  </exception><filterpriority>1</filterpriority>
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
        
        
        [SecuritySafeCriticalAttribute()]
        public override void Reset()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
