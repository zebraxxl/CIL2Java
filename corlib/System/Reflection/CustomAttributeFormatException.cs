using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
    /// <summary>The exception that is thrown when the binary format of a custom attribute is invalid.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CustomAttributeFormatException : FormatException
    {
        public CustomAttributeFormatException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with the specified message.</summary><param name="message">The message that indicates the reason this exception was thrown. </param>
        public CustomAttributeFormatException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public CustomAttributeFormatException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with the specified serialization and context information.</summary><param name="info">The data for serializing or deserializing the custom attribute. </param><param name="context">The source and destination for the custom attribute. </param>
        protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
