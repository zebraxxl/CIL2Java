using System;
using System.Runtime.Serialization;

namespace System.Net.Mail
{
    [Serializable]
    public class SmtpException : Exception, ISerializable
    {
    
        public SmtpStatusCode StatusCode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SmtpException(SmtpStatusCode statusCode)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpException(SmtpStatusCode statusCode, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpException()
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected SmtpException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
