using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
    /// <summary>The exception that is thrown when an attempt to access a class member fails.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class MemberAccessException : SystemException
    {
        public MemberAccessException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with a specified error message.</summary><param name="message">The message that describes the error. </param>
        public MemberAccessException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception. </param>
        public MemberAccessException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param>
        protected MemberAccessException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
