using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    /// <summary>Represents structured exception handling (SEH) errors. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SEHException : ExternalException
    {
        public SEHException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.SEHException" /> class with a specified message.</summary><param name="message">The message that indicates the reason for the exception. </param>
        public SEHException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.SEHException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public SEHException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.SEHException" /> class from serialization data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        protected SEHException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool CanResume()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
