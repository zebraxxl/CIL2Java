using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{
    /// <summary>Provides data for the <see cref="T:System.Exception.SerializeObjectState" /> event.</summary>
    public sealed class SafeSerializationEventArgs : EventArgs
    {
    
        /// <summary>Gets or sets an object that describes the source and destination of a serialized stream.</summary><returns>An object that describes the source and destination of a serialized stream.</returns>
        public StreamingContext StreamingContext
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Stores the state of the exception.</summary><param name="serializedState">A state object that is serialized with the instance.</param>
        public void AddSerializedState(ISafeSerializationData serializedState)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
