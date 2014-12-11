using System;
using System.Runtime.Serialization;

namespace System.Net
{
    [Serializable]
    public class WebException : InvalidOperationException, ISerializable
    {
    
        public WebExceptionStatus Status
        {
            get { throw new NotImplementedException(); }
        }
    
        public WebResponse Response
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebException()
        {
             throw new NotImplementedException();
        }
        
        
        public WebException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public WebException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WebException(string message, WebExceptionStatus status)
        {
             throw new NotImplementedException();
        }
        
        
        public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
        {
             throw new NotImplementedException();
        }
        
        
        protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
