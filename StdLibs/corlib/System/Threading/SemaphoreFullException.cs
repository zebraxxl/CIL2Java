using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Threading
{
    /// <summary>The exception that is thrown when the <see cref="Overload:System.Threading.Semaphore.Release" /> method is called on a semaphore whose count is already at the maximum. </summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(false)]
    public class SemaphoreFullException : SystemException
    {
        public SemaphoreFullException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with a specified error message.</summary><param name="message">The error message that explains the reason for the exception.</param>
        public SemaphoreFullException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception.</param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public SemaphoreFullException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreFullException" /> class with serialized data.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
        protected SemaphoreFullException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
