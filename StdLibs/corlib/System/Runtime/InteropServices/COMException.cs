using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    /// <summary>The exception that is thrown when an unrecognized HRESULT is returned from a COM method call.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class COMException : ExternalException
    {
        public COMException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with a specified message.</summary><param name="message">The message that indicates the reason for the exception. </param>
        public COMException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public COMException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with a specified message and error code.</summary><param name="message">The message that indicates the reason the exception occurred. </param><param name="errorCode">The error code (HRESULT) value associated with this exception. </param>
        public COMException(string message, int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class from serialization data.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that supplies the contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        protected COMException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
