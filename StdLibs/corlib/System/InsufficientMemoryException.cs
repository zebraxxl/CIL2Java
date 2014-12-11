
namespace System
{
    /// <summary>The exception that is thrown when a check for sufficient available memory fails. This class cannot be inherited.</summary>
    [Serializable]
    public sealed class InsufficientMemoryException : OutOfMemoryException
    {
        public InsufficientMemoryException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.InsufficientMemoryException" /> class with a specified message that describes the error.</summary><param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
        public InsufficientMemoryException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.InsufficientMemoryException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public InsufficientMemoryException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
