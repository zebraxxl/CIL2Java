using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Security;
using System.Runtime.Serialization;

namespace System
{
    /// <summary>Represents one or more errors that occur during application execution.</summary>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {InnerExceptionCount}")]
    public class AggregateException : Exception
    {
    
        /// <summary>Gets a read-only collection of the <see cref="T:System.Exception" /> instances that caused the current exception.</summary><returns>Returns a read-only collection of the <see cref="T:System.Exception" /> instances that caused the current exception.</returns>
        public ReadOnlyCollection<Exception> InnerExceptions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AggregateException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with a specified message that describes the error.</summary><param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
        public AggregateException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param><param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param><exception cref="T:System.ArgumentNullException">The <paramref name="innerException" /> argument is null.</exception>
        public AggregateException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public AggregateException(IEnumerable<Exception> innerExceptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with references to the inner exceptions that are the cause of this exception.</summary><param name="innerExceptions">The exceptions that are the cause of the current exception.</param><exception cref="T:System.ArgumentNullException">The <paramref name="innerExceptions" /> argument is null.</exception><exception cref="T:System.ArgumentException">An element of <paramref name="innerExceptions" /> is null.</exception>
        public AggregateException(params  Exception[] innerExceptions)
        {
             throw new NotImplementedException();
        }
        
        
        public AggregateException(string message, IEnumerable<Exception> innerExceptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with a specified error message and references to the inner exceptions that are the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception.</param><param name="innerExceptions">The exceptions that are the cause of the current exception.</param><exception cref="T:System.ArgumentNullException">The <paramref name="innerExceptions" /> argument is null.</exception><exception cref="T:System.ArgumentException">An element of <paramref name="innerExceptions" /> is null.</exception>
        public AggregateException(string message, params  Exception[] innerExceptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> argument is null.</exception><exception cref="T:System.Runtime.Serialization.SerializationException">The exception could not be deserialized correctly.</exception>
        [SecurityCriticalAttribute()]
        protected AggregateException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with serialized data.</summary><param name="info">The object that holds the serialized object data. </param><param name="context">The contextual information about the source or destination. </param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> argument is null.</exception>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override Exception GetBaseException()
        {
             throw new NotImplementedException();
        }
        
        
        public void Handle(Func<Exception, bool> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        public AggregateException Flatten()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
