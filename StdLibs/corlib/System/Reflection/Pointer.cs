using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System;

namespace System.Reflection
{
    /// <summary>Provides a wrapper class for pointers.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Pointer : ISerializable
    {
    
        /// <summary>Boxes the supplied unmanaged memory pointer and the type associated with that pointer into a managed <see cref="T:System.Reflection.Pointer" /> wrapper object. The value and the type are saved so they can be accessed from the native code during an invocation.</summary><returns>A pointer object.</returns><param name="ptr">The supplied unmanaged memory pointer. </param><param name="type">The type associated with the <paramref name="ptr" /> parameter. </param><exception cref="T:System.ArgumentException"><paramref name="type" /> is not a pointer. </exception><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null. </exception>
        [SecurityCriticalAttribute()]
        public unsafe static object Box(void* ptr, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the stored pointer.</summary><returns>This method returns void.</returns><param name="ptr">The stored pointer. </param><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is not a pointer. </exception>
        [SecurityCriticalAttribute()]
        public unsafe static void* Unbox(object ptr)
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
