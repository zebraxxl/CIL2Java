using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
    [Serializable]
    public class WarningException : SystemException
    {
    
        public string HelpUrl
        {
            get { throw new NotImplementedException(); }
        }
    
        public string HelpTopic
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WarningException()
        {
             throw new NotImplementedException();
        }
        
        
        public WarningException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public WarningException(string message, string helpUrl)
        {
             throw new NotImplementedException();
        }
        
        
        public WarningException(string message, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        public WarningException(string message, string helpUrl, string helpTopic)
        {
             throw new NotImplementedException();
        }
        
        
        protected WarningException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
