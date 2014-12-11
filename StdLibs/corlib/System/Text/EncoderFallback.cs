
namespace System.Text
{
    /// <summary>Provides a failure-handling mechanism, called a fallback, for an input character that cannot be converted to an encoded output byte sequence. </summary><filterpriority>2</filterpriority>
    [Serializable]
    public abstract class EncoderFallback
    {
    
        /// <summary>Gets an object that outputs a substitute string in place of an input character that cannot be encoded.</summary><returns>A type derived from the <see cref="T:System.Text.EncoderFallback" /> class. The default value is a <see cref="T:System.Text.EncoderReplacementFallback" /> object that replaces unknown input characters with the QUESTION MARK character ("?", U+003F).</returns><filterpriority>1</filterpriority>
        public static EncoderFallback ReplacementFallback
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that throws an exception when an input character cannot be encoded.</summary><returns>A type derived from the <see cref="T:System.Text.EncoderFallback" /> class. The default value is a <see cref="T:System.Text.EncoderExceptionFallback" /> object.</returns><filterpriority>1</filterpriority>
        public static EncoderFallback ExceptionFallback
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>When overridden in a derived class, gets the maximum number of characters the current <see cref="T:System.Text.EncoderFallback" /> object can return.</summary><returns>The maximum number of characters the current <see cref="T:System.Text.EncoderFallback" /> object can return.</returns><filterpriority>2</filterpriority>
        public abstract int MaxCharCount
        {
            get;
        }
    
    
        public abstract EncoderFallbackBuffer CreateFallbackBuffer();
        
        
        protected EncoderFallback()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
