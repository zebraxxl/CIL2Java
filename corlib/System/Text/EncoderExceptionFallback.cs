
namespace System.Text
{
    /// <summary>Throws a <see cref="T:System.Text.EncoderFallbackException" /> if an input character cannot be converted to an encoded output byte sequence. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class EncoderExceptionFallback : EncoderFallback
    {
        /// <summary>Gets the maximum number of characters this instance can return.</summary><returns>The return value is always zero.</returns><filterpriority>2</filterpriority>
        public override int MaxCharCount
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EncoderExceptionFallback()
        {
             throw new NotImplementedException();
        }
        
        
        public override EncoderFallbackBuffer CreateFallbackBuffer()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current <see cref="T:System.Text.EncoderExceptionFallback" /> object and a specified object are equal.</summary><returns>true if <paramref name="value" /> is not null (Nothing in Visual Basic .NET) and is a <see cref="T:System.Text.EncoderExceptionFallback" /> object; otherwise, false.</returns><param name="value">An object that derives from the <see cref="T:System.Text.EncoderExceptionFallback" /> class.</param><filterpriority>2</filterpriority>
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
