
namespace System.Text
{
    /// <summary>Provides a failure handling mechanism, called a fallback, for an input character that cannot be converted to an output byte sequence. The fallback uses a user-specified replacement string instead of the original input character. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class EncoderReplacementFallback : EncoderFallback
    {
    
        /// <summary>Gets the replacement string that is the value of the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary><returns>A substitute string that is used in place of an input character that cannot be encoded.</returns><filterpriority>2</filterpriority>
        public string DefaultString
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of characters in the replacement string for the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary><returns>The number of characters in the string used in place of an input character that cannot be encoded.</returns><filterpriority>2</filterpriority>
        public override int MaxCharCount
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EncoderReplacementFallback()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallback" /> class using a specified replacement string.</summary><param name="replacement">A string that is converted in an encoding operation in place of an input character that cannot be encoded.</param><exception cref="T:System.ArgumentNullException"><paramref name="replacement" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="replacement" /> contains an invalid surrogate pair. In other words, the surrogate does not consist of one high surrogate component followed by one low surrogate component.</exception>
        public EncoderReplacementFallback(string replacement)
        {
             throw new NotImplementedException();
        }
        
        
        public override EncoderFallbackBuffer CreateFallbackBuffer()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the value of a specified object is equal to the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary><returns>true if the <paramref name="value" /> parameter specifies an <see cref="T:System.Text.EncoderReplacementFallback" /> object and the replacement string of that object is equal to the replacement string of this <see cref="T:System.Text.EncoderReplacementFallback" /> object; otherwise, false. </returns><param name="value">A <see cref="T:System.Text.EncoderReplacementFallback" /> object.</param><filterpriority>2</filterpriority>
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
