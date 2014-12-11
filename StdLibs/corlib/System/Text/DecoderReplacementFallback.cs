
namespace System.Text
{
    /// <summary>Provides a failure-handling mechanism, called a fallback, for an encoded input byte sequence that cannot be converted to an output character. The fallback emits a user-specified replacement string instead of a decoded input byte sequence. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class DecoderReplacementFallback : DecoderFallback
    {
    
        /// <summary>Gets the replacement string that is the value of the <see cref="T:System.Text.DecoderReplacementFallback" /> object.</summary><returns>A substitute string that is emitted in place of an input byte sequence that cannot be decoded.</returns><filterpriority>2</filterpriority>
        public string DefaultString
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of characters in the replacement string for the <see cref="T:System.Text.DecoderReplacementFallback" /> object.</summary><returns>The number of characters in the string that is emitted in place of a byte sequence that cannot be decoded, that is, the length of the string returned by the <see cref="P:System.Text.DecoderReplacementFallback.DefaultString" /> property.</returns><filterpriority>2</filterpriority>
        public override int MaxCharCount
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DecoderReplacementFallback()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderReplacementFallback" /> class using a specified replacement string.</summary><param name="replacement">A string that is emitted in a decoding operation in place of an input byte sequence that cannot be decoded.</param><exception cref="T:System.ArgumentNullException"><paramref name="replacement" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="replacement" /> contains an invalid surrogate pair. In other words, the surrogate pair does not consist of one high surrogate component followed by one low surrogate component.</exception>
        public DecoderReplacementFallback(string replacement)
        {
             throw new NotImplementedException();
        }
        
        
        public override DecoderFallbackBuffer CreateFallbackBuffer()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the value of a specified object is equal to the <see cref="T:System.Text.DecoderReplacementFallback" /> object.</summary><returns>true if <paramref name="value" /> is a <see cref="T:System.Text.DecoderReplacementFallback" /> object having a <see cref="P:System.Text.DecoderReplacementFallback.DefaultString" /> property that is equal to the <see cref="P:System.Text.DecoderReplacementFallback.DefaultString" /> property of the current <see cref="T:System.Text.DecoderReplacementFallback" /> object; otherwise, false. </returns><param name="value">A <see cref="T:System.Text.DecoderReplacementFallback" /> object.</param><filterpriority>2</filterpriority>
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
