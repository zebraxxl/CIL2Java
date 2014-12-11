using System;
using System.Runtime.Serialization;

namespace System.Threading
{
    /// <summary>The exception that is thrown when recursive entry into a lock is not compatible with the recursion policy for the lock.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public class LockRecursionException : Exception
    {
        public LockRecursionException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with a specified message that describes the error.</summary><param name="message">The message that describes the exception. The caller of this constructor must make sure that this string has been localized for the current system culture. </param><filterpriority>2</filterpriority>
        public LockRecursionException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data.</param><param name="context">The contextual information about the source or destination.</param>
        protected LockRecursionException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The message that describes the exception. The caller of this constructor must make sure that this string has been localized for the current system culture. </param><param name="innerException">The exception that caused the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param><filterpriority>2</filterpriority>
        public LockRecursionException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
