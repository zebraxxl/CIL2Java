using System.Runtime.InteropServices;
using System;

namespace System.Collections
{
    /// <summary>Manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0).</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class BitArray : ICollection, ICloneable
    {
    
        /// <summary>Gets or sets the value of the bit at a specific position in the <see cref="T:System.Collections.BitArray" />.</summary><returns>The value of the bit at position <paramref name="index" />.</returns><param name="index">The zero-based index of the value to get or set. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.BitArray.Count" />. </exception><filterpriority>2</filterpriority>
        public bool this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of elements in the <see cref="T:System.Collections.BitArray" />.</summary><returns>The number of elements in the <see cref="T:System.Collections.BitArray" />.</returns><exception cref="T:System.ArgumentOutOfRangeException">The property is set to a value that is less than zero. </exception><filterpriority>2</filterpriority>
        public int Length
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.BitArray" />.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.BitArray" />.</returns><filterpriority>2</filterpriority>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.BitArray" />.</summary><returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.BitArray" />.</returns><filterpriority>2</filterpriority>
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.BitArray" /> is read-only.</summary><returns>This property is always false.</returns><filterpriority>2</filterpriority>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.BitArray" /> is synchronized (thread safe).</summary><returns>This property is always false.</returns><filterpriority>2</filterpriority>
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that can hold the specified number of bit values, which are initially set to false.</summary><param name="length">The number of bit values in the new <see cref="T:System.Collections.BitArray" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length" /> is less than zero. </exception>
        public BitArray(int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that can hold the specified number of bit values, which are initially set to the specified value.</summary><param name="length">The number of bit values in the new <see cref="T:System.Collections.BitArray" />. </param><param name="defaultValue">The Boolean value to assign to each bit. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length" /> is less than zero. </exception>
        public BitArray(int length, bool defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that contains bit values copied from the specified array of bytes.</summary><param name="bytes">An array of bytes containing the values to copy, where each byte represents eight consecutive bits. </param><exception cref="T:System.ArgumentNullException"><paramref name="bytes" /> is null. </exception><exception cref="T:System.ArgumentException">The length of <paramref name="bytes" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public BitArray(byte[] bytes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that contains bit values copied from the specified array of Booleans.</summary><param name="values">An array of Booleans to copy. </param><exception cref="T:System.ArgumentNullException"><paramref name="values" /> is null. </exception>
        public BitArray(bool[] values)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that contains bit values copied from the specified array of 32-bit integers.</summary><param name="values">An array of integers containing the values to copy, where each integer represents 32 consecutive bits. </param><exception cref="T:System.ArgumentNullException"><paramref name="values" /> is null. </exception><exception cref="T:System.ArgumentException">The length of <paramref name="values" /> is greater than <see cref="F:System.Int32.MaxValue" /></exception>
        public BitArray(int[] values)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that contains bit values copied from the specified <see cref="T:System.Collections.BitArray" />.</summary><param name="bits">The <see cref="T:System.Collections.BitArray" /> to copy. </param><exception cref="T:System.ArgumentNullException"><paramref name="bits" /> is null. </exception>
        public BitArray(BitArray bits)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value of the bit at a specific position in the <see cref="T:System.Collections.BitArray" />.</summary><returns>The value of the bit at position <paramref name="index" />.</returns><param name="index">The zero-based index of the value to get. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is greater than or equal to the number of elements in the <see cref="T:System.Collections.BitArray" />. </exception><filterpriority>2</filterpriority>
        public bool Get(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the bit at a specific position in the <see cref="T:System.Collections.BitArray" /> to the specified value.</summary><param name="index">The zero-based index of the bit to set. </param><param name="value">The Boolean value to assign to the bit. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is greater than or equal to the number of elements in the <see cref="T:System.Collections.BitArray" />. </exception><filterpriority>2</filterpriority>
        public void Set(int index, bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets all bits in the <see cref="T:System.Collections.BitArray" /> to the specified value.</summary><param name="value">The Boolean value to assign to all bits. </param><filterpriority>2</filterpriority>
        public void SetAll(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs the bitwise AND operation on the elements in the current <see cref="T:System.Collections.BitArray" /> against the corresponding elements in the specified <see cref="T:System.Collections.BitArray" />.</summary><returns>The current instance containing the result of the bitwise AND operation on the elements in the current <see cref="T:System.Collections.BitArray" /> against the corresponding elements in the specified <see cref="T:System.Collections.BitArray" />.</returns><param name="value">The <see cref="T:System.Collections.BitArray" /> with which to perform the bitwise AND operation. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> and the current <see cref="T:System.Collections.BitArray" /> do not have the same number of elements. </exception><filterpriority>2</filterpriority>
        public BitArray And(BitArray value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs the bitwise OR operation on the elements in the current <see cref="T:System.Collections.BitArray" /> against the corresponding elements in the specified <see cref="T:System.Collections.BitArray" />.</summary><returns>The current instance containing the result of the bitwise OR operation on the elements in the current <see cref="T:System.Collections.BitArray" /> against the corresponding elements in the specified <see cref="T:System.Collections.BitArray" />.</returns><param name="value">The <see cref="T:System.Collections.BitArray" /> with which to perform the bitwise OR operation. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> and the current <see cref="T:System.Collections.BitArray" /> do not have the same number of elements. </exception><filterpriority>2</filterpriority>
        public BitArray Or(BitArray value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs the bitwise exclusive OR operation on the elements in the current <see cref="T:System.Collections.BitArray" /> against the corresponding elements in the specified <see cref="T:System.Collections.BitArray" />.</summary><returns>The current instance containing the result of the bitwise exclusive OR operation on the elements in the current <see cref="T:System.Collections.BitArray" /> against the corresponding elements in the specified <see cref="T:System.Collections.BitArray" />. </returns><param name="value">The <see cref="T:System.Collections.BitArray" /> with which to perform the bitwise exclusive OR operation. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> and the current <see cref="T:System.Collections.BitArray" /> do not have the same number of elements. </exception><filterpriority>2</filterpriority>
        public BitArray Xor(BitArray value)
        {
             throw new NotImplementedException();
        }
        
        
        public BitArray Not()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the entire <see cref="T:System.Collections.BitArray" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.BitArray" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.BitArray" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.BitArray" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
