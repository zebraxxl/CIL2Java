using System.Runtime.Serialization;
using System.Security;

namespace System
{
    /// <summary>Represents a typed weak reference, which references an object while still allowing that object to be reclaimed by garbage collection.</summary><typeparam name="T">The type of the object referenced.</typeparam>
    [Serializable]
    public sealed class WeakReference<T> : ISerializable
    {
    
    
        public WeakReference(T target)
        {
             throw new NotImplementedException();
        }
        
        
        public WeakReference(T target, bool trackResurrection)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryGetTarget(ref T target)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetTarget(T target)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        ~WeakReference()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data necessary to serialize the current <see cref="T:System.WeakReference`1" /> object.</summary><param name="info">An object that holds all the data necessary to serialize or deserialize the current <see cref="T:System.WeakReference`1" /> object.</param><param name="context">The location where serialized data is stored and retrieved.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
