using System.Runtime.Serialization;

namespace System
{
    /// <summary>The exception that is thrown when a method attempts to use a type that it does not have access to.</summary>
    [Serializable]
    public class TypeAccessException : TypeLoadException
    {
        public TypeAccessException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with a specified message that describes the error.</summary><param name="message">The message that describes the exception. The caller of this constructor must ensure that this string has been localized for the current system culture.</param>
        public TypeAccessException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The message that describes the exception. The caller of this constructor must ensure that this string has been localized for the current system culture. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public TypeAccessException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with serialized data.</summary><param name="info">The object that holds the serialized data. </param><param name="context">The contextual information about the source or destination. </param>
        protected TypeAccessException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
