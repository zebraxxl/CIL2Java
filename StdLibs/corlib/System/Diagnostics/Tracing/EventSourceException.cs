using System;
using System.Runtime.Serialization;

namespace System.Diagnostics.Tracing
{
    /// <summary>The exception that is thrown when an error occurs during event tracing for Windows (ETW).</summary>
    [Serializable]
    public class EventSourceException : Exception
    {
        public EventSourceException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSourceException" /> class with a specified error message.</summary><param name="message">The message that describes the error.</param>
        public EventSourceException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSourceException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception, or null if no inner exception is specified. </param>
        public EventSourceException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSourceException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data.</param><param name="context">The contextual information about the source or destination.</param>
        protected EventSourceException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
