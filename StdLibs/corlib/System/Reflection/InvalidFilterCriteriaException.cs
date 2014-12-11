using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
    /// <summary>The exception that is thrown in <see cref="M:System.Type.FindMembers(System.Reflection.MemberTypes,System.Reflection.BindingFlags,System.Reflection.MemberFilter,System.Object)" /> when the filter criteria is not valid for the type of filter you are using.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class InvalidFilterCriteriaException : ApplicationException
    {
        public InvalidFilterCriteriaException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with the given HRESULT and message string.</summary><param name="message">The message text for the exception. </param>
        public InvalidFilterCriteriaException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public InvalidFilterCriteriaException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> class with the specified serialization and context information.</summary><param name="info">A SerializationInfo object that contains the information required to serialize this instance. </param><param name="context">A StreamingContext object that contains the source and destination of the serialized stream associated with this instance. </param>
        protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
