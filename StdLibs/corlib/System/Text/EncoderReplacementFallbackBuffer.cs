using System.Security;

namespace System.Text
{
    /// <summary>Represents a substitute input string that is used when the original input character cannot be encoded. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
    {
    
        /// <summary>Gets the number of characters in the replacement fallback buffer that remain to be processed.</summary><returns>The number of characters in the replacement fallback buffer that have not yet been processed.</returns><filterpriority>1</filterpriority>
        public override int Remaining
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallbackBuffer" /> class using the value of a <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary><param name="fallback">A <see cref="T:System.Text.EncoderReplacementFallback" /> object. </param>
        public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Prepares the replacement fallback buffer to use the current replacement string.</summary><returns>true if the replacement string is not empty; false if the replacement string is empty.</returns><param name="charUnknown">An input character. This parameter is ignored in this operation unless an exception is thrown.</param><param name="index">The index position of the character in the input buffer. This parameter is ignored in this operation.</param><exception cref="T:System.ArgumentException">This method is called again before the <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> method has read all the characters in the replacement fallback buffer.  </exception><filterpriority>1</filterpriority>
        public override bool Fallback(char charUnknown, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a replacement string can be used when an input surrogate pair cannot be encoded, or whether the surrogate pair can be ignored. Parameters specify the surrogate pair and the index position of the pair in the input.</summary><returns>true if the replacement string is not empty; false if the replacement string is empty.</returns><param name="charUnknownHigh">The high surrogate of the input pair.</param><param name="charUnknownLow">The low surrogate of the input pair.</param><param name="index">The index position of the surrogate pair in the input buffer.</param><exception cref="T:System.ArgumentException">This method is called again before the <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> method has read all the replacement string characters. </exception><exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="charUnknownHigh" /> is less than U+D800 or greater than U+D8FF.-or-The value of <paramref name="charUnknownLow" /> is less than U+DC00 or greater than U+DFFF.</exception><filterpriority>1</filterpriority>
        public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
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
