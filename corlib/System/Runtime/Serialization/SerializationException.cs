using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>The exception thrown when an error occurs during serialization or deserialization.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SerializationException : SystemException
    {
    
        public SerializationException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class with a specified message.</summary><param name="message">Indicates the reason why the exception occurred. </param>
        public SerializationException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public SerializationException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationException" /> class from serialized data.</summary><param name="info">The serialization information object holding the serialized object data in the name-value form. </param><param name="context">The contextual information about the source or destination of the exception. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected SerializationException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
