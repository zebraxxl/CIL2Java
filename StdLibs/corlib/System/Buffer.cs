using System.Runtime.InteropServices;
using System.Security;

namespace System
{
    /// <summary>Manipulates arrays of primitive types.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public static class Buffer
    {
        /// <summary>Copies a specified number of bytes from a source array starting at a particular offset to a destination array starting at a particular offset.</summary><param name="src">The source buffer. </param><param name="srcOffset">The zero-based byte offset into <paramref name="src" />. </param><param name="dst">The destination buffer. </param><param name="dstOffset">The zero-based byte offset into <paramref name="dst" />. </param><param name="count">The number of bytes to copy. </param><exception cref="T:System.ArgumentNullException"><paramref name="src" /> or <paramref name="dst" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="src" /> or <paramref name="dst" /> is not an array of primitives.-or- The number of bytes in <paramref name="src" /> is less than <paramref name="srcOffset" /> plus <paramref name="count" />.-or- The number of bytes in <paramref name="dst" /> is less than <paramref name="dstOffset" /> plus <paramref name="count" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="srcOffset" />, <paramref name="dstOffset" />, or <paramref name="count" /> is less than 0. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the byte at a specified location in a specified array.</summary><returns>Returns the <paramref name="index" /> byte in the array.</returns><param name="array">An array. </param><param name="index">A location in the array. </param><exception cref="T:System.ArgumentException"><paramref name="array" /> is not a primitive. </exception><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is negative or greater than the length of <paramref name="array" />. </exception><exception cref="T:System.OverflowException"><paramref name="array" /> is larger than 2 gigabytes (GB).</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static byte GetByte(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Assigns a specified value to a byte at a particular location in a specified array.</summary><param name="array">An array. </param><param name="index">A location in the array. </param><param name="value">A value to assign. </param><exception cref="T:System.ArgumentException"><paramref name="array" /> is not a primitive. </exception><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is negative or greater than the length of <paramref name="array" />. </exception><exception cref="T:System.OverflowException"><paramref name="array" /> is larger than 2 gigabytes (GB).</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void SetByte(Array array, int index, byte value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the number of bytes in the specified array.</summary><returns>The number of bytes in the array.</returns><param name="array">An array. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is not a primitive. </exception><exception cref="T:System.OverflowException"><paramref name="array" /> is larger than 2 gigabytes (GB).</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static int ByteLength(Array array)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
