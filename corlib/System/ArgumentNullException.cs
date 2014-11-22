using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization;

namespace System
{
    /// <summary>The exception that is thrown when a null reference (Nothing in Visual Basic) is passed to a method that does not accept it as a valid argument. </summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ArgumentNullException : ArgumentException
    {
        public ArgumentNullException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentNullException" /> class with the name of the parameter that causes this exception.</summary><param name="paramName">The name of the parameter that caused the exception. </param>
        public ArgumentNullException(string paramName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentNullException" /> class with a specified error message and the exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for this exception. </param><param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public ArgumentNullException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes an instance of the <see cref="T:System.ArgumentNullException" /> class with a specified error message and the name of the parameter that causes this exception.</summary><param name="paramName">The name of the parameter that caused the exception. </param><param name="message">A message that describes the error. </param>
        public ArgumentNullException(string paramName, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ArgumentNullException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">An object that describes the source or destination of the serialized data. </param>
        [SecurityCriticalAttribute()]
        protected ArgumentNullException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
