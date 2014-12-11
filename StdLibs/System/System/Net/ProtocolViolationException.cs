using System;
using System.Runtime.Serialization;

namespace System.Net
{
    [Serializable]
    public class ProtocolViolationException : InvalidOperationException, ISerializable
    {
        public ProtocolViolationException()
        {
             throw new NotImplementedException();
        }
        
        
        public ProtocolViolationException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
