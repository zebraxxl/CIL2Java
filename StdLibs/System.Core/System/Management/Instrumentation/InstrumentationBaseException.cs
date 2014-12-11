using System;
using System.Runtime.Serialization;

namespace System.Management.Instrumentation
{
    [Serializable]
    public class InstrumentationBaseException : Exception
    {
        public InstrumentationBaseException()
        {
             throw new NotImplementedException();
        }
        
        
        public InstrumentationBaseException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public InstrumentationBaseException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected InstrumentationBaseException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
