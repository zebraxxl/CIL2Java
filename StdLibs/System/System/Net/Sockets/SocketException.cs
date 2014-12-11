using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.Sockets
{
    [Serializable]
    public class SocketException : Win32Exception
    {
    
        public override int ErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        public SocketError SocketErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SocketException()
        {
             throw new NotImplementedException();
        }
        
        
        public SocketException(int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
