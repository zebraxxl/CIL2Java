using System.Runtime.Serialization;
using System;

namespace System.Security.Authentication
{
    [Serializable]
    public class InvalidCredentialException : AuthenticationException
    {
        public InvalidCredentialException()
        {
             throw new NotImplementedException();
        }
        
        
        protected InvalidCredentialException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public InvalidCredentialException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public InvalidCredentialException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
