using System.Security;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a controlled memory buffer that can be used for reading and writing. Attempts to access memory outside the controlled buffer (underruns and overruns) raise exceptions.</summary>
    [SecurityCriticalAttribute()]
    public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
    {
    
        /// <summary>Gets the size of the buffer, in bytes.</summary><returns>The number of bytes in the memory buffer.</returns><exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> method has not been called.</exception>
        public ulong ByteLength
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Creates a new instance of the <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> class, and specifies whether the buffer handle is to be reliably released. </summary><param name="ownsHandle">true to reliably release the handle during the finalization phase; false to prevent reliable release (not recommended).</param>
        protected SafeBuffer(bool ownsHandle)
            : base(ownsHandle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Defines the allocation size of the memory region in bytes. You must call this method before you use the <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> instance.</summary><param name="numBytes">The number of bytes in the buffer.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="numBytes" /> is less than zero.-or-<paramref name="numBytes" /> is greater than the available address space.</exception>
        public void Initialize(ulong numBytes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies the allocation size of the memory buffer by using the specified number of elements and element size. You must call this method before you use the <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> instance.</summary><param name="numElements">The number of elements in the buffer.</param><param name="sizeOfEachElement">The size of each element in the buffer.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="numElements" /> is less than zero. -or-<paramref name="sizeOfEachElement" /> is less than zero.-or-<paramref name="numElements" /> multiplied by <paramref name="sizeOfEachElement" /> is greater than the available address space.</exception>
        public void Initialize(uint numElements, uint sizeOfEachElement)
        {
             throw new NotImplementedException();
        }
        
        
        public void Initialize<T>(uint numElements)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public void AcquirePointer(ref byte pointer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public void ReleasePointer()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public T Read<T>(ulong byteOffset)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public void ReadArray<T>(ulong byteOffset, T[] array, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public void Write<T>(ulong byteOffset, T value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public void WriteArray<T>(ulong byteOffset, T[] array, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
