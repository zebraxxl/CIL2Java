using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>The exception that is thrown to communicate errors to the client when the client connects to non-.NET Framework applications that cannot throw exceptions.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ServerException : SystemException
    {
    
        public ServerException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ServerException" /> class with a specified message.</summary><param name="message">The message that describes the exception </param>
        public ServerException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ServerException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="InnerException">The exception that is the cause of the current exception. If the <paramref name="InnerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public ServerException(string message, Exception InnerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
