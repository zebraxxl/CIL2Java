using System;
using System.Security;
using System.Runtime.Serialization;

namespace System.Threading
{
    [Serializable]
    public class BarrierPostPhaseException : Exception
    {
        public BarrierPostPhaseException()
        {
             throw new NotImplementedException();
        }
        
        
        public BarrierPostPhaseException(Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public BarrierPostPhaseException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public BarrierPostPhaseException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected BarrierPostPhaseException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
