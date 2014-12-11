using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
    [Serializable]
    public class NetworkInformationException : Win32Exception
    {
        public override int ErrorCode
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NetworkInformationException()
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkInformationException(int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
