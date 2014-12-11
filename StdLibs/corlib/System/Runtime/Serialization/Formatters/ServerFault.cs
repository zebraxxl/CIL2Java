using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Contains information for a server fault. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [SoapTypeAttribute(Embedded = true)]
    public sealed class ServerFault
    {
    
        /// <summary>Gets or sets the type of exception that was thrown by the server.</summary><returns>The type of exception that was thrown by the server.</returns>
        public string ExceptionType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the exception message that accompanied the exception thrown on the server.</summary><returns>The exception message that accompanied the exception thrown on the server.</returns>
        public string ExceptionMessage
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the stack trace of the thread that threw the exception on the server.</summary><returns>The stack trace of the thread that threw the exception on the server.</returns>
        public string StackTrace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.ServerFault" /> class.</summary><param name="exceptionType">The type of the exception that occurred on the server. </param><param name="message">The message that accompanied the exception. </param><param name="stackTrace">The stack trace of the thread that threw the exception on the server. </param>
        public ServerFault(string exceptionType, string message, string stackTrace)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
