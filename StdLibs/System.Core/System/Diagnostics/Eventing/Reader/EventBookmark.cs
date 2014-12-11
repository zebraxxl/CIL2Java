using System.Runtime.Serialization;
using System.Security;

namespace System.Diagnostics.Eventing.Reader
{
    [Serializable]
    public class EventBookmark : ISerializable
    {
    
    
        protected EventBookmark(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
