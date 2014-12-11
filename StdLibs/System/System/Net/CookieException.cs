using System;
using System.Runtime.Serialization;

namespace System.Net
{
    [Serializable]
    public class CookieException : FormatException, ISerializable
    {
        public CookieException()
        {
             throw new NotImplementedException();
        }
        
        
        protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
