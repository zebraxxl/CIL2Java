using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;

namespace System.ComponentModel.Design
{
    [Serializable]
    public class CheckoutException : ExternalException
    {
        public static readonly CheckoutException Canceled;
    
        public CheckoutException()
        {
             throw new NotImplementedException();
        }
        
        
        public CheckoutException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public CheckoutException(string message, int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        protected CheckoutException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public CheckoutException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
