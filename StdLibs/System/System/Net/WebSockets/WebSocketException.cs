using System.ComponentModel;
using System;
using System.Runtime.Serialization;

namespace System.Net.WebSockets
{
    [Serializable]
    public sealed class WebSocketException : Win32Exception
    {
    
        public override int ErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
        public WebSocketError WebSocketErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebSocketException()
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(int nativeError)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(int nativeError, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(int nativeError, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, int nativeError)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, int nativeError, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, int nativeError, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(WebSocketError error, int nativeError, string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
