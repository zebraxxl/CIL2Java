using System.Runtime.Serialization;
using System.Security;
using System.Runtime.InteropServices;

namespace System.Threading
{
    /// <summary>Provides methods for setting and capturing the compressed stack on the current thread. This class cannot be inherited. </summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class CompressedStack : ISerializable
    {
    
    
        /// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of this execution context.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to be populated with serialization information. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure representing the destination context of the serialization. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><filterpriority>1</filterpriority>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static CompressedStack GetCompressedStack()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static CompressedStack Capture()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Runs a method in the specified compressed stack on the current thread.</summary><param name="compressedStack">The <see cref="T:System.Threading.CompressedStack" /> to set.</param><param name="callback">A <see cref="T:System.Threading.ContextCallback" /> that represents the method to be run in the specified security context.</param><param name="state">The object to be passed to the callback method.</param><exception cref="T:System.ArgumentException"><paramref name="compressedStack" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public static void Run(CompressedStack compressedStack, ContextCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public CompressedStack CreateCopy()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
