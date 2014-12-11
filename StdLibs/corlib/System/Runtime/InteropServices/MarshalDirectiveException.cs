using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    /// <summary>The exception that is thrown by the marshaler when it encounters a <see cref="T:System.Runtime.InteropServices.MarshalAsAttribute" /> it does not support.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class MarshalDirectiveException : SystemException
    {
        public MarshalDirectiveException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the MarshalDirectiveException class with a specified error message.</summary><param name="message">The error message that specifies the reason for the exception. </param>
        public MarshalDirectiveException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.MarshalDirectiveException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public MarshalDirectiveException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the MarshalDirectiveException class from serialization data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        protected MarshalDirectiveException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
