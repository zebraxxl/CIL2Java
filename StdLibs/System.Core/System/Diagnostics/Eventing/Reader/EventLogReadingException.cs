using System;
using System.Runtime.Serialization;

namespace System.Diagnostics.Eventing.Reader
{
    [Serializable]
    public class EventLogReadingException : EventLogException
    {
        public EventLogReadingException()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogReadingException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogReadingException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventLogReadingException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
