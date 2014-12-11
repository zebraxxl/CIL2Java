using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
    [Serializable]
    public class InvalidEnumArgumentException : ArgumentException
    {
        public InvalidEnumArgumentException()
        {
             throw new NotImplementedException();
        }
        
        
        public InvalidEnumArgumentException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public InvalidEnumArgumentException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
        {
             throw new NotImplementedException();
        }
        
        
        protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
