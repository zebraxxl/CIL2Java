using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Runtime.ConstrainedExecution;

namespace System
{
    /// <summary>A platform-specific type that is used to represent a pointer or a handle.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct IntPtr : ISerializable
    {
        /// <summary>A read-only field that represents a pointer or handle that has been initialized to zero.</summary><filterpriority>1</filterpriority>
        public static readonly IntPtr Zero;
    
        /// <summary>Gets the size of this instance.</summary><returns>The size of a pointer or handle in this process, measured in bytes. The value of this property is 4 in a 32-bit process, and 8 in a 64-bit process. You can define the process type by setting the /platform switch when you compile your code with the C# and Visual Basic compilers.</returns><filterpriority>1</filterpriority>
        public static int Size
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified 32-bit pointer or handle.</summary><param name="value">A pointer or handle contained in a 32-bit signed integer. </param>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public IntPtr(int value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified 64-bit pointer.</summary><param name="value">A pointer or handle contained in a 64-bit signed integer. </param><exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large or too small to represent as an <see cref="T:System.IntPtr" />. </exception>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public IntPtr(long value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified pointer to an unspecified type.</summary><param name="value">A pointer to an unspecified type. </param>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public unsafe IntPtr(void* value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.IntPtr" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance or null. </param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public int ToInt32()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public long ToInt64()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the numeric value of the current <see cref="T:System.IntPtr" /> object to its equivalent string representation.</summary><returns>The string representation of the value of the current <see cref="T:System.IntPtr" /> object.</returns><param name="format">A format specification that governs how the current <see cref="T:System.IntPtr" /> object is converted. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public string ToString(string format)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static explicit operator IntPtr(int value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static explicit operator IntPtr(long value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public unsafe static explicit operator IntPtr(void* value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public unsafe static explicit operator void*(IntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static explicit operator int(IntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static explicit operator long(IntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are equal.</summary><returns>true if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare.</param><param name="value2">The second pointer or handle to compare.</param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are equal.</summary><returns>true if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare.</param><param name="value2">The second pointer or handle to compare.</param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static bool operator ==(IntPtr value1, IntPtr value2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are not equal.</summary><returns>true if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare. </param><param name="value2">The second pointer or handle to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are not equal.</summary><returns>true if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare. </param><param name="value2">The second pointer or handle to compare. </param><filterpriority>3</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static bool operator !=(IntPtr value1, IntPtr value2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an offset to the value of a pointer.</summary><returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns><param name="pointer">The pointer to add the offset to.</param><param name="offset">The offset to add.</param>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static IntPtr Add(IntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an offset to the value of a pointer.</summary><returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns><param name="pointer">The pointer to add the offset to.</param><param name="offset">The offset to add.</param>
        /// <summary>Adds an offset to the value of a pointer.</summary><returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns><param name="pointer">The pointer to add the offset to.</param><param name="offset">The offset to add.</param>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static IntPtr operator +(IntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts an offset from the value of a pointer.</summary><returns>A new pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns><param name="pointer">The pointer to subtract the offset from.</param><param name="offset">The offset to subtract.</param>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static IntPtr Subtract(IntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts an offset from the value of a pointer.</summary><returns>A new pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns><param name="pointer">The pointer to subtract the offset from.</param><param name="offset">The offset to subtract.</param>
        /// <summary>Subtracts an offset from the value of a pointer.</summary><returns>A new pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns><param name="pointer">The pointer to subtract the offset from.</param><param name="offset">The offset to subtract.</param>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static IntPtr operator -(IntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public unsafe void* ToPointer()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
