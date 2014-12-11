using System.Security;

namespace System.Text
{
    /// <summary>Provides a buffer that allows a fallback handler to return an alternate string to an encoder when it cannot encode an input character. </summary><filterpriority>2</filterpriority>
    public abstract class EncoderFallbackBuffer
    {
    
        /// <summary>When overridden in a derived class, gets the number of characters in the current <see cref="T:System.Text.EncoderFallbackBuffer" /> object that remain to be processed.</summary><returns>The number of characters in the current fallback buffer that have not yet been processed.</returns><filterpriority>1</filterpriority>
        public abstract int Remaining
        {
            get;
        }
    
    
        /// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified input character. </summary><returns>true if the fallback buffer can process <paramref name="charUnknown" />; false if the fallback buffer ignores <paramref name="charUnknown" />.</returns><param name="charUnknown">An input character.</param><param name="index">The index position of the character in the input buffer.</param><filterpriority>1</filterpriority>
        public abstract bool Fallback(char charUnknown, int index);
        
        
        /// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified surrogate pair.</summary><returns>true if the fallback buffer can process <paramref name="charUnknownHigh" /> and <paramref name="charUnknownLow" />; false if the fallback buffer ignores the surrogate pair.</returns><param name="charUnknownHigh">The high surrogate of the input pair.</param><param name="charUnknownLow">The low surrogate of the input pair.</param><param name="index">The index position of the surrogate pair in the input buffer.</param><filterpriority>1</filterpriority>
        public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
        
        
        public abstract char GetNextChar();
        
        
        public abstract bool MovePrevious();
        
        
        public virtual void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        protected EncoderFallbackBuffer()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
