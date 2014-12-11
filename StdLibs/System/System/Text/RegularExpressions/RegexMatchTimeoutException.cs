using System;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions
{
    [Serializable]
    public class RegexMatchTimeoutException : TimeoutException, ISerializable
    {
    
        public string Pattern
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Input
        {
            get { throw new NotImplementedException(); }
        }
    
        public TimeSpan MatchTimeout
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public RegexMatchTimeoutException()
        {
             throw new NotImplementedException();
        }
        
        
        public RegexMatchTimeoutException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public RegexMatchTimeoutException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
