using System;

namespace System.Text
{
    /// <summary>The exception that is thrown when a decoder fallback operation fails. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class DecoderFallbackException : ArgumentException
    {
    
        /// <summary>Gets the input byte sequence that caused the exception.</summary><returns>The input byte array that cannot be decoded. </returns><filterpriority>2</filterpriority>
        public byte[] BytesUnknown
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the index position in the input byte sequence of the byte that caused the exception.</summary><returns>The index position in the input byte array of the byte that cannot be decoded. The index position is zero-based. </returns><filterpriority>1</filterpriority>
        public int Index
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DecoderFallbackException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class. A parameter specifies the error message.</summary><param name="message">An error message.</param>
        public DecoderFallbackException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class. Parameters specify the error message and the inner exception that is the cause of this exception.</summary><param name="message">An error message.</param><param name="innerException">The exception that caused this exception.</param>
        public DecoderFallbackException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class. Parameters specify the error message, the array of bytes being decoded, and the index of the byte that cannot be decoded.</summary><param name="message">An error message.</param><param name="bytesUnknown">The input byte array.</param><param name="index">The index position in <paramref name="bytesUnknown" /> of the byte that cannot be decoded.</param>
        public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
