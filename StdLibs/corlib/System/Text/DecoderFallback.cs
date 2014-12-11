
namespace System.Text
{
    /// <summary>Provides a failure-handling mechanism, called a fallback, for an encoded input byte sequence that cannot be converted to an output character. </summary><filterpriority>2</filterpriority>
    [Serializable]
    public abstract class DecoderFallback
    {
    
        /// <summary>Gets an object that outputs a substitute string in place of an input byte sequence that cannot be decoded.</summary><returns>A type derived from the <see cref="T:System.Text.DecoderFallback" /> class. The default value is a <see cref="T:System.Text.DecoderReplacementFallback" /> object that emits the QUESTION MARK character ("?", U+003F) in place of unknown byte sequences. </returns><filterpriority>1</filterpriority>
        public static DecoderFallback ReplacementFallback
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that throws an exception when an input byte sequence cannot be decoded.</summary><returns>A type derived from the <see cref="T:System.Text.DecoderFallback" /> class. The default value is a <see cref="T:System.Text.DecoderExceptionFallback" /> object.</returns><filterpriority>1</filterpriority>
        public static DecoderFallback ExceptionFallback
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the maximum number of characters the current <see cref="T:System.Text.DecoderFallback" /> object can return.</summary><returns>The maximum number of characters the current <see cref="T:System.Text.DecoderFallback" /> object can return.</returns><filterpriority>2</filterpriority>
        public abstract int MaxCharCount
        {
            get;
        }
    
    
        public abstract DecoderFallbackBuffer CreateFallbackBuffer();
        
        
        protected DecoderFallback()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
