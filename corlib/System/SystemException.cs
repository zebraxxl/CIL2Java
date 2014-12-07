using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
    /// <summary>
    /// Defines the base class for predefined exceptions in the <see cref="N:System" /> namespace.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SystemException : Exception
    {
        private const int Result = unchecked((int)0x80131501);

        public SystemException()
            : base(Local.GetText("A system exception has occurred."))
        {
            HResult = Result;
        }
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.SystemException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public SystemException(string message)
            : base(message)
        {
            HResult = Result;
        }
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.SystemException" /> class with a specified error message
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception. </param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the 
        /// <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic),
        /// the current exception is raised in a catch block that handles the inner exception. </param>
        public SystemException(string message, Exception innerException)
            : base(message, innerException)
        {
            HResult = Result;
        }
        
        
        /// <summary
        /// >Initializes a new instance of the <see cref="T:System.SystemException" /> class with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data. </param>
        /// <param name="context">The contextual information about the source or destination. </param>
        protected SystemException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            HResult = Result;
        }
        
        
    }
}
