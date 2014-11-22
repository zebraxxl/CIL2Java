using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
    /// <summary>A platform-specific type that is used to represent a pointer or a handle.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public struct UIntPtr : ISerializable
    {
        /// <summary>A read-only field that represents a pointer or handle that has been initialized to zero.</summary><filterpriority>1</filterpriority>
        public static readonly UIntPtr Zero;
    
        /// <summary>Gets the size of this instance.</summary><returns>The size of a pointer or handle on this platform, measured in bytes. The value of this property is 4 on a 32-bit platform, and 8 on a 64-bit platform.</returns><filterpriority>1</filterpriority>
        public static int Size
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.UIntPtr" /> structure using the specified 32-bit pointer or handle.</summary><param name="value">A pointer or handle contained in a 32-bit unsigned integer. </param>
        [SecuritySafeCriticalAttribute()]
        public UIntPtr(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.UIntPtr" /> using the specified 64-bit pointer or handle.</summary><param name="value">A pointer or handle contained in a 64-bit unsigned integer. </param><exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large to represent as an <see cref="T:System.UIntPtr" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public UIntPtr(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of <see cref="T:System.UIntPtr" /> using the specified pointer to an unspecified type.</summary><param name="value">A pointer to an unspecified type. </param>
        [SecurityCriticalAttribute()]
        public unsafe UIntPtr(void* value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is an instance of <see cref="T:System.UIntPtr" /> and equals the value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance or null. </param><filterpriority>2</filterpriority>
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
        public uint ToUInt32()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public ulong ToUInt64()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator UIntPtr(uint value)
        {
             throw new NotImplementedException();
        }
        
        
        public static explicit operator UIntPtr(ulong value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static explicit operator uint(UIntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static explicit operator ulong(UIntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public unsafe static explicit operator UIntPtr(void* value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public unsafe static explicit operator void*(UIntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are equal.</summary><returns>true if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare. </param><param name="value2">The second pointer or handle to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are equal.</summary><returns>true if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare. </param><param name="value2">The second pointer or handle to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator ==(UIntPtr value1, UIntPtr value2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are not equal.</summary><returns>true if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare. </param><param name="value2">The second pointer or handle to compare. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are not equal.</summary><returns>true if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, false.</returns><param name="value1">The first pointer or handle to compare. </param><param name="value2">The second pointer or handle to compare. </param><filterpriority>3</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static bool operator !=(UIntPtr value1, UIntPtr value2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an offset to the value of an unsigned pointer.</summary><returns>A new unsigned pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns><param name="pointer">The unsigned pointer to add the offset to.</param><param name="offset">The offset to add.</param>
        public static UIntPtr Add(UIntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an offset to the value of an unsigned pointer.</summary><returns>A new unsigned pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns><param name="pointer">The unsigned pointer to add the offset to.</param><param name="offset">The offset to add.</param>
        /// <summary>Adds an offset to the value of an unsigned pointer.</summary><returns>A new unsigned pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns><param name="pointer">The unsigned pointer to add the offset to.</param><param name="offset">The offset to add.</param>
        public static UIntPtr operator +(UIntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts an offset from the value of an unsigned pointer.</summary><returns>A new unsigned pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns><param name="pointer">The unsigned pointer to subtract the offset from.</param><param name="offset">The offset to subtract.</param>
        public static UIntPtr Subtract(UIntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Subtracts an offset from the value of an unsigned pointer.</summary><returns>A new unsigned pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns><param name="pointer">The unsigned pointer to subtract the offset from.</param><param name="offset">The offset to subtract.</param>
        /// <summary>Subtracts an offset from the value of an unsigned pointer.</summary><returns>A new unsigned pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns><param name="pointer">The unsigned pointer to subtract the offset from.</param><param name="offset">The offset to subtract.</param>
        public static UIntPtr operator -(UIntPtr pointer, int offset)
        {
             throw new NotImplementedException();
        }
        
        
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
