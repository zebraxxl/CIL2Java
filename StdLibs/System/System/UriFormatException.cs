using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    public class UriFormatException : FormatException, ISerializable
    {
        public UriFormatException()
        {
             throw new NotImplementedException();
        }
        
        
        public UriFormatException(string textString)
        {
             throw new NotImplementedException();
        }
        
        
        public UriFormatException(string textString, Exception e)
        {
             throw new NotImplementedException();
        }
        
        
        protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
