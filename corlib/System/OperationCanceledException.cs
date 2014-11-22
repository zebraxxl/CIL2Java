using System.Runtime.InteropServices;
using System.Threading;
using System.Runtime.Serialization;

namespace System
{
    /// <summary>The exception that is thrown in a thread upon cancellation of an operation that the thread was executing.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class OperationCanceledException : SystemException
    {
    
        /// <summary>Gets a token associated with the operation that was canceled.</summary><returns>A token associated with the operation that was canceled, or a default token.</returns>
        public CancellationToken CancellationToken
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public OperationCanceledException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message.</summary><param name="message">A <see cref="T:System.String" /> that describes the error.</param>
        public OperationCanceledException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public OperationCanceledException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a cancellation token.</summary><param name="token">A cancellation token associated with the operation that was canceled.</param>
        public OperationCanceledException(CancellationToken token)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message and a cancellation token.</summary><param name="message">The error message that explains the reason for the exception.</param><param name="token">A cancellation token associated with the operation that was canceled.</param>
        public OperationCanceledException(string message, CancellationToken token)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message, a reference to the inner exception that is the cause of this exception, and a cancellation token.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param><param name="token">A cancellation token associated with the operation that was canceled.</param>
        public OperationCanceledException(string message, Exception innerException, CancellationToken token)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param>
        protected OperationCanceledException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
