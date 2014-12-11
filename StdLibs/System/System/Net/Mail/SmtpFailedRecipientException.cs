using System.Runtime.Serialization;
using System;

namespace System.Net.Mail
{
    [Serializable]
    public class SmtpFailedRecipientException : SmtpException, ISerializable
    {
    
        public string FailedRecipient
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SmtpFailedRecipientException()
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected SmtpFailedRecipientException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientException(SmtpStatusCode statusCode, string failedRecipient)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientException(SmtpStatusCode statusCode, string failedRecipient, string serverResponse)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientException(string message, string failedRecipient, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
