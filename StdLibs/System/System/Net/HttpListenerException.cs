using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net
{
    [Serializable]
    public class HttpListenerException : Win32Exception
    {
        public override int ErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HttpListenerException()
        {
             throw new NotImplementedException();
        }
        
        
        public HttpListenerException(int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public HttpListenerException(int errorCode, string message)
        {
             throw new NotImplementedException();
        }
        
        
        protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
