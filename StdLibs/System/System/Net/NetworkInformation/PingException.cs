using System;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
    [Serializable]
    public class PingException : InvalidOperationException
    {
        protected PingException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public PingException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public PingException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
