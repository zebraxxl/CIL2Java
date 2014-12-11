using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
    /// <summary>The exception that is thrown when something has gone wrong during remoting.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class RemotingException : SystemException
    {
    
        public RemotingException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class with a specified message.</summary><param name="message">The error message that explains why the exception occurred. </param>
        public RemotingException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains why the exception occurred. </param><param name="InnerException">The exception that is the cause of the current exception. If the <paramref name="InnerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public RemotingException(string message, Exception InnerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingException" /> class from serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination of the exception. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        protected RemotingException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
