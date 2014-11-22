using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>The exception that is thrown when the server or the client cannot be reached for a previously specified period of time.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class RemotingTimeoutException : RemotingException
    {
    
        public RemotingTimeoutException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.Runtime.Remoting.RemotingTimeoutException" /> class with a specified message.</summary><param name="message">The message that indicates the reason why the exception occurred. </param>
        public RemotingTimeoutException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.RemotingTimeoutException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="InnerException">The exception that is the cause of the current exception. If the <paramref name="InnerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public RemotingTimeoutException(string message, Exception InnerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
