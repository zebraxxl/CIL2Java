using System.Runtime.InteropServices;

namespace System
{
    /// <summary>The exception that is thrown when there is an internal error in the execution engine of the common language runtime. This class cannot be inherited.  </summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ObsoleteAttribute("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
    public sealed class ExecutionEngineException : SystemException
    {
        public ExecutionEngineException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ExecutionEngineException" /> class with a specified error message.</summary><param name="message">The message that describes the error. </param>
        public ExecutionEngineException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ExecutionEngineException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception. </param>
        public ExecutionEngineException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
