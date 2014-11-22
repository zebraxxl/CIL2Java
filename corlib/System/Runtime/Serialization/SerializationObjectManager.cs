using System.Security;

namespace System.Runtime.Serialization
{
    /// <summary>Manages serialization processes at run time. This class cannot be inherited.</summary>
    public sealed class SerializationObjectManager
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationObjectManager" /> class. </summary><param name="context">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that contains information about the current serialization operation.</param>
        public SerializationObjectManager(StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Registers the object upon which events will be raised.</summary><param name="obj">The object to register.</param>
        [SecurityCriticalAttribute()]
        public void RegisterObject(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public void RaiseOnSerializedEvent()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
