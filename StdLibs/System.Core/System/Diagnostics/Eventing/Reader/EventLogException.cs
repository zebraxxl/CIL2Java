using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Diagnostics.Eventing.Reader
{
    [Serializable]
    public class EventLogException : Exception, ISerializable
    {
    
        public override string Message
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventLogException()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventLogException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventLogException(int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
