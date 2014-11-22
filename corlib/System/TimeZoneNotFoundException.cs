using System.Runtime.Serialization;

namespace System
{
    /// <summary>The exception that is thrown when a time zone cannot be found.</summary>
    [Serializable]
    public class TimeZoneNotFoundException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class with the specified message string.</summary><param name="message">A string that describes the exception.</param>
        public TimeZoneNotFoundException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">A string that describes the exception.    </param><param name="innerException">The exception that is the cause of the current exception.  </param>
        public TimeZoneNotFoundException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class from serialized data.</summary><param name="info">The object that contains the serialized data.</param><param name="context">The stream that contains the serialized data.</param><exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null.-or-The <paramref name="context" /> parameter is null.</exception>
        protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public TimeZoneNotFoundException()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
