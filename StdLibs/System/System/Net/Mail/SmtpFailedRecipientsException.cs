using System.Runtime.Serialization;
using System;

namespace System.Net.Mail
{
    [Serializable]
    public class SmtpFailedRecipientsException : SmtpFailedRecipientException, ISerializable
    {
    
        public SmtpFailedRecipientException[] InnerExceptions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SmtpFailedRecipientsException()
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientsException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientsException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        protected SmtpFailedRecipientsException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpFailedRecipientsException(string message, SmtpFailedRecipientException[] innerExceptions)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
