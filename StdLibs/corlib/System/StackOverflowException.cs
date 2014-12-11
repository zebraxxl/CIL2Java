using System.Runtime.InteropServices;

namespace System
{
    /// <summary>The exception that is thrown when the execution stack overflows because it contains too many nested method calls. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class StackOverflowException : SystemException
    {
        public StackOverflowException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.StackOverflowException" /> class with a specified error message.</summary><param name="message">A <see cref="T:System.String" /> that describes the error. The content of message is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
        public StackOverflowException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.StackOverflowException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception. </param>
        public StackOverflowException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
