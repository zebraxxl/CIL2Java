using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    /// <summary>The base exception type for all COM interop exceptions and structured exception handling (SEH) exceptions.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ExternalException : SystemException
    {
        /// <summary>Gets the HRESULT of the error.</summary><returns>The HRESULT of the error.</returns>
        public virtual int ErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ExternalException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the ExternalException class with a specified error message.</summary><param name="message">The error message that specifies the reason for the exception. </param>
        public ExternalException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ExternalException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public ExternalException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the ExternalException class with a specified error message and the HRESULT of the error.</summary><param name="message">The error message that specifies the reason for the exception. </param><param name="errorCode">The HRESULT of the error. </param>
        public ExternalException(string message, int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the ExternalException class from serialization data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        protected ExternalException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
