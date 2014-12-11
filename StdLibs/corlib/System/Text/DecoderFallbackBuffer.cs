using System.Security;

namespace System.Text
{
    /// <summary>Provides a buffer that allows a fallback handler to return an alternate string to a decoder when it cannot decode an input byte sequence. </summary><filterpriority>2</filterpriority>
    public abstract class DecoderFallbackBuffer
    {
    
        /// <summary>When overridden in a derived class, gets the number of characters in the current <see cref="T:System.Text.DecoderFallbackBuffer" /> object that remain to be processed.</summary><returns>The number of characters in the current fallback buffer that have not yet been processed.</returns><filterpriority>1</filterpriority>
        public abstract int Remaining
        {
            get;
        }
    
    
        /// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified input byte sequence.</summary><returns>true if the fallback buffer can process <paramref name="bytesUnknown" />; false if the fallback buffer ignores <paramref name="bytesUnknown" />.</returns><param name="bytesUnknown">An input array of bytes.</param><param name="index">The index position of a byte in <paramref name="bytesUnknown" />.</param><filterpriority>1</filterpriority>
        public abstract bool Fallback(byte[] bytesUnknown, int index);
        
        
        public abstract char GetNextChar();
        
        
        public abstract bool MovePrevious();
        
        
        public virtual void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        protected DecoderFallbackBuffer()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
