using System;

namespace System.Text
{
    /// <summary>The exception that is thrown when an encoder fallback operation fails. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class EncoderFallbackException : ArgumentException
    {
    
        /// <summary>Gets the input character that caused the exception.</summary><returns>The character that cannot be encoded.</returns><filterpriority>2</filterpriority>
        public char CharUnknown
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the high component character of the surrogate pair that caused the exception.</summary><returns>The high component character of the surrogate pair that cannot be encoded.</returns><filterpriority>2</filterpriority>
        public char CharUnknownHigh
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the low component character of the surrogate pair that caused the exception.</summary><returns>The low component character of the surrogate pair that cannot be encoded.</returns><filterpriority>2</filterpriority>
        public char CharUnknownLow
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the index position in the input buffer of the character that caused the exception.</summary><returns>The index position in the input buffer of the character that cannot be encoded.</returns><filterpriority>1</filterpriority>
        public int Index
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EncoderFallbackException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackException" /> class. A parameter specifies the error message.</summary><param name="message">An error message.</param>
        public EncoderFallbackException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackException" /> class. Parameters specify the error message and the inner exception that is the cause of this exception.</summary><param name="message">An error message.</param><param name="innerException">The exception that caused this exception.</param>
        public EncoderFallbackException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnknownSurrogate()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
