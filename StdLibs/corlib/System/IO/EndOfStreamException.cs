using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.IO
{
    /// <summary>The exception that is thrown when reading is attempted past the end of a stream.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class EndOfStreamException : IOException
    {
        public EndOfStreamException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.EndOfStreamException" /> class with its message string set to <paramref name="message" /> and its HRESULT set to COR_E_ENDOFSTREAM.</summary><param name="message">A string that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
        public EndOfStreamException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.EndOfStreamException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">A string that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public EndOfStreamException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.EndOfStreamException" /> class with the specified serialization and context information.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
        protected EndOfStreamException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
