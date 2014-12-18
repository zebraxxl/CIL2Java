using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Collections.Generic;
using CIL2Java.Attributes;
using arrayMap = CIL2Java.Maps.Array;

namespace System
{
    /// <summary>Provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [TypeMap(typeof(object))]
    public abstract class Array : ICloneable, IList, IStructuralComparable, IStructuralEquatable
    {
    
        /// <summary>Gets a 32-bit integer that represents the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</summary><returns>A 32-bit integer that represents the total number of elements in all the dimensions of the <see cref="T:System.Array" />; zero if there are no elements in the array.</returns><exception cref="T:System.OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception><filterpriority>1</filterpriority>
        public int Length
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a 64-bit integer that represents the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</summary><returns>A 64-bit integer that represents the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</returns><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public long LongLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the rank (number of dimensions) of the <see cref="T:System.Array" />.</summary><returns>The rank (number of dimensions) of the <see cref="T:System.Array" />.</returns><filterpriority>1</filterpriority>
        public int Rank
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Array" />.</summary><returns>An object that can be used to synchronize access to the <see cref="T:System.Array" />.</returns><filterpriority>2</filterpriority>
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Array" /> is read-only.</summary><returns>This property is always false for all arrays.</returns><filterpriority>2</filterpriority>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Array" /> has a fixed size.</summary><returns>This property is always true for all arrays.</returns><filterpriority>2</filterpriority>
        public bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the <see cref="T:System.Array" /> is synchronized (thread safe).</summary><returns>This property is always false for all arrays.</returns><filterpriority>2</filterpriority>
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [MethodMap(typeof(arrayMap), "Resize")]
        public static void Resize<T>(ref T[] array, int newSize)
        {
            throw new NotSupportedException(Local.GetText("Dierect call to mapped methods not supported"));
        }
        
        
        /// <summary>Creates a one-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and length, with zero-based indexing.</summary><returns>A new one-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length, using zero-based indexing.</returns><param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param><param name="length">The size of the <see cref="T:System.Array" /> to create.</param><exception cref="T:System.ArgumentNullException"><paramref name="elementType" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception><exception cref="T:System.NotSupportedException"><paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.-or-<paramref name="elementType" /> is an open generic type.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length" /> is less than zero.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Array CreateInstance(Type elementType, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a two-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing.</summary><returns>A new two-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns><param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param><param name="length1">The size of the first dimension of the <see cref="T:System.Array" /> to create.</param><param name="length2">The size of the second dimension of the <see cref="T:System.Array" /> to create.</param><exception cref="T:System.ArgumentNullException"><paramref name="elementType" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception><exception cref="T:System.NotSupportedException"><paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-<paramref name="elementType" /> is an open generic type.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length1" /> is less than zero.-or-<paramref name="length2" /> is less than zero.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Array CreateInstance(Type elementType, int length1, int length2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a three-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing.</summary><returns>A new three-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns><param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param><param name="length1">The size of the first dimension of the <see cref="T:System.Array" /> to create.</param><param name="length2">The size of the second dimension of the <see cref="T:System.Array" /> to create.</param><param name="length3">The size of the third dimension of the <see cref="T:System.Array" /> to create.</param><exception cref="T:System.ArgumentNullException"><paramref name="elementType" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception><exception cref="T:System.NotSupportedException"><paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-<paramref name="elementType" /> is an open generic type.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length1" /> is less than zero.-or-<paramref name="length2" /> is less than zero.-or-<paramref name="length3" /> is less than zero.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Array CreateInstance(Type elementType, int length1, int length2, int length3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.</summary><returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns><param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param><param name="lengths">An array of 32-bit integers that represent the size of each dimension of the <see cref="T:System.Array" /> to create.</param><exception cref="T:System.ArgumentNullException"><paramref name="elementType" /> is null.-or-<paramref name="lengths" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.-or-The <paramref name="lengths" /> array contains less than one element.</exception><exception cref="T:System.NotSupportedException"><paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-<paramref name="elementType" /> is an open generic type.</exception><exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Array CreateInstance(Type elementType, params  int[] lengths)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 64-bit integers.</summary><returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns><param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param><param name="lengths">An array of 64-bit integers that represent the size of each dimension of the <see cref="T:System.Array" /> to create. Each integer in the array must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param><exception cref="T:System.ArgumentNullException"><paramref name="elementType" /> is null.-or-<paramref name="lengths" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.-or-The <paramref name="lengths" /> array contains less than one element.</exception><exception cref="T:System.NotSupportedException"><paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-<paramref name="elementType" /> is an open generic type.</exception><exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero or greater than <see cref="F:System.Int32.MaxValue" />.</exception><filterpriority>1</filterpriority>
        public static Array CreateInstance(Type elementType, params  long[] lengths)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with the specified lower bounds.</summary><returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length and lower bound for each dimension.</returns><param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param><param name="lengths">A one-dimensional array that contains the size of each dimension of the <see cref="T:System.Array" /> to create.</param><param name="lowerBounds">A one-dimensional array that contains the lower bound (starting index) of each dimension of the <see cref="T:System.Array" /> to create.</param><exception cref="T:System.ArgumentNullException"><paramref name="elementType" /> is null.-or-<paramref name="lengths" /> is null.-or-<paramref name="lowerBounds" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.-or-The <paramref name="lengths" /> array contains less than one element.-or-The <paramref name="lengths" /> and <paramref name="lowerBounds" /> arrays do not contain the same number of elements.</exception><exception cref="T:System.NotSupportedException"><paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported. -or-<paramref name="elementType" /> is an open generic type.</exception><exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero.-or-Any value in <paramref name="lowerBounds" /> is very large, such that the sum of a dimension's lower bound and length is greater than <see cref="F:System.Int32.MaxValue" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the first element and pastes them into another <see cref="T:System.Array" /> starting at the first element. The length is specified as a 32-bit integer.</summary><param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param><param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param><param name="length">A 32-bit integer that represents the number of elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="sourceArray" /> is null.-or-<paramref name="destinationArray" /> is null.</exception><exception cref="T:System.RankException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception><exception cref="T:System.ArrayTypeMismatchException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception><exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="length" /> is greater than the number of elements in <paramref name="sourceArray" />.-or-<paramref name="length" /> is greater than the number of elements in <paramref name="destinationArray" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Copy(Array sourceArray, Array destinationArray, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>
        /// Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source
        /// index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination
        /// index. The length and the indexes are specified as 32-bit integers.
        /// </summary>
        /// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="sourceArray" /> is null.-or-<paramref name="destinationArray" /> is null.</exception>
        /// <exception cref="T:System.RankException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
        /// <exception cref="T:System.ArrayTypeMismatchException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
        /// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="sourceIndex" /> is less than the lower bound of the first dimension of <paramref name="sourceArray" />.-or-<paramref name="destinationIndex" /> is less than the lower bound of the first dimension of <paramref name="destinationArray" />.-or-<paramref name="length" /> is less than zero.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.-or-<paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
        /// <filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(arrayMap), "Copy")]
        public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
        {
            throw new NotSupportedException(Local.GetText("Dierect call to mapped methods not supported"));
        }
        
        
        /// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index.  Guarantees that all changes are undone if the copy does not succeed completely.</summary><param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param><param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param><param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param><param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param><param name="length">A 32-bit integer that represents the number of elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="sourceArray" /> is null.-or-<paramref name="destinationArray" /> is null.</exception><exception cref="T:System.RankException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception><exception cref="T:System.ArrayTypeMismatchException">The <paramref name="sourceArray" /> type is neither the same as nor derived from the <paramref name="destinationArray" /> type.</exception><exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="sourceIndex" /> is less than the lower bound of the first dimension of <paramref name="sourceArray" />.-or-<paramref name="destinationIndex" /> is less than the lower bound of the first dimension of <paramref name="destinationArray" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.-or-<paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the first element and pastes them into another <see cref="T:System.Array" /> starting at the first element. The length is specified as a 64-bit integer.</summary><param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param><param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param><param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param><exception cref="T:System.ArgumentNullException"><paramref name="sourceArray" /> is null.-or-<paramref name="destinationArray" /> is null.</exception><exception cref="T:System.RankException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception><exception cref="T:System.ArrayTypeMismatchException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception><exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length" /> is less than 0 or greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.ArgumentException"><paramref name="length" /> is greater than the number of elements in <paramref name="sourceArray" />.-or-<paramref name="length" /> is greater than the number of elements in <paramref name="destinationArray" />.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Copy(Array sourceArray, Array destinationArray, long length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index. The length and the indexes are specified as 64-bit integers.</summary><param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param><param name="sourceIndex">A 64-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param><param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param><param name="destinationIndex">A 64-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param><param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param><exception cref="T:System.ArgumentNullException"><paramref name="sourceArray" /> is null.-or-<paramref name="destinationArray" /> is null.</exception><exception cref="T:System.RankException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception><exception cref="T:System.ArrayTypeMismatchException"><paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception><exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="sourceIndex" /> is outside the range of valid indexes for the <paramref name="sourceArray" />.-or-<paramref name="destinationIndex" /> is outside the range of valid indexes for the <paramref name="destinationArray" />.-or-<paramref name="length" /> is less than 0 or greater than <see cref="F:System.Int32.MaxValue" />.</exception><exception cref="T:System.ArgumentException"><paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.-or-<paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a range of elements in the <see cref="T:System.Array" /> to zero, to false, or to null, depending on the element type.</summary><param name="array">The <see cref="T:System.Array" /> whose elements need to be cleared.</param><param name="index">The starting index of the range of elements to clear.</param><param name="length">The number of elements to clear.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.IndexOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-<paramref name="length" /> is less than zero.-or-The sum of <paramref name="index" /> and <paramref name="length" /> is greater than the size of the <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(arrayMap), "Clear")]
        public static void Clear(Array array, int index, int length)
        {
            throw new NotSupportedException(Local.GetText("Dierect call to mapped methods not supported"));
        }
        
        
        /// <summary>Gets the value at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 32-bit integers.</summary><returns>The value at the specified position in the multidimensional <see cref="T:System.Array" />.</returns><param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentNullException"><paramref name="indices" /> is null.</exception><exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception><exception cref="T:System.IndexOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(params  int[] indices)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 32-bit integer.</summary><returns>The value at the specified position in the one-dimensional <see cref="T:System.Array" />.</returns><param name="index">A 32-bit integer that represents the position of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception><exception cref="T:System.IndexOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary><returns>The value at the specified position in the two-dimensional <see cref="T:System.Array" />.</returns><param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param><param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception><exception cref="T:System.IndexOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(int index1, int index2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary><returns>The value at the specified position in the three-dimensional <see cref="T:System.Array" />.</returns><param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param><param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param><param name="index3">A 32-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception><exception cref="T:System.IndexOutOfRangeException"><paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(int index1, int index2, int index3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 64-bit integer.</summary><returns>The value at the specified position in the one-dimensional <see cref="T:System.Array" />.</returns><param name="index">A 64-bit integer that represents the position of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public object GetValue(long index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary><returns>The value at the specified position in the two-dimensional <see cref="T:System.Array" />.</returns><param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param><param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception><exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public object GetValue(long index1, long index2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary><returns>The value at the specified position in the three-dimensional <see cref="T:System.Array" />.</returns><param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param><param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param><param name="index3">A 64-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public object GetValue(long index1, long index2, long index3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 64-bit integers.</summary><returns>The value at the specified position in the multidimensional <see cref="T:System.Array" />.</returns><param name="indices">A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the <see cref="T:System.Array" /> element to get.</param><exception cref="T:System.ArgumentNullException"><paramref name="indices" /> is null.</exception><exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception><exception cref="T:System.ArgumentOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public object GetValue(params  long[] indices)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 32-bit integer.</summary><param name="value">The new value for the specified element.</param><param name="index">A 32-bit integer that represents the position of the <see cref="T:System.Array" /> element to set.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.IndexOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [MethodMap(typeof(CIL2Java.Maps.Array), "SetValue", true)]
        public void SetValue(object value, int index)
        {
            throw new InvalidOperationException(Local.GetText("Mapped method calling not supported"));
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary><param name="value">The new value for the specified element.</param><param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param><param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.IndexOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void SetValue(object value, int index1, int index2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary><param name="value">The new value for the specified element.</param><param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param><param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param><param name="index3">A 32-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to set.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.IndexOutOfRangeException"><paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void SetValue(object value, int index1, int index2, int index3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 32-bit integers.</summary><param name="value">The new value for the specified element.</param><param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the element to set.</param><exception cref="T:System.ArgumentNullException"><paramref name="indices" /> is null.</exception><exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.IndexOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public void SetValue(object value, params  int[] indices)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 64-bit integer.</summary><param name="value">The new value for the specified element.</param><param name="index">A 64-bit integer that represents the position of the <see cref="T:System.Array" /> element to set.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public void SetValue(object value, long index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary><param name="value">The new value for the specified element.</param><param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param><param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public void SetValue(object value, long index1, long index2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary><param name="value">The new value for the specified element.</param><param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param><param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param><param name="index3">A 64-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to set.</param><exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public void SetValue(object value, long index1, long index2, long index3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a value to the element at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 64-bit integers.</summary><param name="value">The new value for the specified element.</param><param name="indices">A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the element to set.</param><exception cref="T:System.ArgumentNullException"><paramref name="indices" /> is null.</exception><exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception><exception cref="T:System.InvalidCastException"><paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception><exception cref="T:System.ArgumentOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception><filterpriority>1</filterpriority>
        [ComVisibleAttribute(false)]
        public void SetValue(object value, params  long[] indices)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a 32-bit integer that represents the number of elements in the specified dimension of the <see cref="T:System.Array" />.</summary><returns>A 32-bit integer that represents the number of elements in the specified dimension.</returns><param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose length needs to be determined.</param><exception cref="T:System.IndexOutOfRangeException"><paramref name="dimension" /> is less than zero.-or-<paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public int GetLength(int dimension)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a 64-bit integer that represents the number of elements in the specified dimension of the <see cref="T:System.Array" />.</summary><returns>A 64-bit integer that represents the number of elements in the specified dimension.</returns><param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose length needs to be determined.</param><exception cref="T:System.IndexOutOfRangeException"><paramref name="dimension" /> is less than zero.-or-<paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public long GetLongLength(int dimension)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the upper bound of the specified dimension in the <see cref="T:System.Array" />.</summary><returns>The upper bound of the specified dimension in the <see cref="T:System.Array" />.</returns><param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose upper bound needs to be determined.</param><exception cref="T:System.IndexOutOfRangeException"><paramref name="dimension" /> is less than zero.-or-<paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public int GetUpperBound(int dimension)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the lower bound of the specified dimension in the <see cref="T:System.Array" />.</summary><returns>The lower bound of the specified dimension in the <see cref="T:System.Array" />.</returns><param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose lower bound needs to be determined.</param><exception cref="T:System.IndexOutOfRangeException"><paramref name="dimension" /> is less than zero.-or-<paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public int GetLowerBound(int dimension)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches an entire one-dimensional sorted <see cref="T:System.Array" /> for a specific element, using the <see cref="T:System.IComparable" /> interface implemented by each element of the <see cref="T:System.Array" /> and by the specified object.</summary><returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, a negative number which is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than any of the elements in <paramref name="array" />, a negative number which is the bitwise complement of (the index of the last element plus 1).</returns><param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception><exception cref="T:System.InvalidOperationException"><paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch(Array array, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches a range of elements in a one-dimensional sorted <see cref="T:System.Array" /> for a value, using the <see cref="T:System.IComparable" /> interface implemented by each element of the <see cref="T:System.Array" /> and by the specified value.</summary><returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, a negative number which is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than any of the elements in <paramref name="array" />, a negative number which is the bitwise complement of (the index of the last element plus 1).</returns><param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param><param name="index">The starting index of the range to search.</param><param name="length">The length of the range to search.</param><param name="value">The object to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.-or-<paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception><exception cref="T:System.InvalidOperationException"><paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch(Array array, int index, int length, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches an entire one-dimensional sorted <see cref="T:System.Array" /> for a value using the specified <see cref="T:System.Collections.IComparer" /> interface.</summary><returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, a negative number which is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than any of the elements in <paramref name="array" />, a negative number which is the bitwise complement of (the index of the last element plus 1).</returns><param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to search for.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- null to use the <see cref="T:System.IComparable" /> implementation of each element.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentException"><paramref name="comparer" /> is null, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null, <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch(Array array, object value, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches a range of elements in a one-dimensional sorted <see cref="T:System.Array" /> for a value, using the specified <see cref="T:System.Collections.IComparer" /> interface.</summary><returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, a negative number which is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than any of the elements in <paramref name="array" />, a negative number which is the bitwise complement of (the index of the last element plus 1).</returns><param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param><param name="index">The starting index of the range to search.</param><param name="length">The length of the range to search.</param><param name="value">The object to search for.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- null to use the <see cref="T:System.IComparable" /> implementation of each element.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.-or-<paramref name="comparer" /> is null, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null, <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch<T>(T[] array, T value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch<T>(T[] array, int index, int length, T value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies all the elements of the current one-dimensional <see cref="T:System.Array" /> to the specified one-dimensional <see cref="T:System.Array" /> starting at the specified destination <see cref="T:System.Array" /> index. The index is specified as a 32-bit integer.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the current <see cref="T:System.Array" />.</param><param name="index">A 32-bit integer that represents the index in <paramref name="array" /> at which copying begins.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.</exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or-The number of elements in the source <see cref="T:System.Array" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception><exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Array" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception><exception cref="T:System.RankException">The source <see cref="T:System.Array" /> is multidimensional.</exception><exception cref="T:System.InvalidCastException">At least one element in the source <see cref="T:System.Array" /> cannot be cast to the type of destination <paramref name="array" />.</exception><filterpriority>2</filterpriority>
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies all the elements of the current one-dimensional <see cref="T:System.Array" /> to the specified one-dimensional <see cref="T:System.Array" /> starting at the specified destination <see cref="T:System.Array" /> index. The index is specified as a 64-bit integer.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the current <see cref="T:System.Array" />.</param><param name="index">A 64-bit integer that represents the index in <paramref name="array" /> at which copying begins.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for <paramref name="array" />.</exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or-The number of elements in the source <see cref="T:System.Array" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception><exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Array" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception><exception cref="T:System.RankException">The source <see cref="T:System.Array" /> is multidimensional.</exception><exception cref="T:System.InvalidCastException">At least one element in the source <see cref="T:System.Array" /> cannot be cast to the type of destination <paramref name="array" />.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public void CopyTo(Array array, long index)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static T Find<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static T[] FindAll<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FindIndex<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static T FindLast<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FindLastIndex<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public static void ForEach<T>(T[] array, Action<T> action)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional <see cref="T:System.Array" />.</summary><returns>The index of the first occurrence of <paramref name="value" /> within the entire <paramref name="array" />, if found; otherwise, the lower bound of the array minus 1.</returns><param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to locate in <paramref name="array" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int IndexOf(Array array, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified object and returns the index of the first occurrence within the range of elements in the one-dimensional <see cref="T:System.Array" /> that extends from the specified index to the last element.</summary><returns>The index of the first occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that extends from <paramref name="startIndex" /> to the last element, if found; otherwise, the lower bound of the array minus 1.</returns><param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to locate in <paramref name="array" />.</param><param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int IndexOf(Array array, object value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified object and returns the index of the first occurrence within the range of elements in the one-dimensional <see cref="T:System.Array" /> that starts at the specified index and contains the specified number of elements.</summary><returns>The index of the first occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified in <paramref name="count" />, if found; otherwise, the lower bound of the array minus 1.</returns><param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to locate in <paramref name="array" />.</param><param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param><param name="count">The number of elements in the section to search.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.-or-<paramref name="count" /> is less than zero.-or-<paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int IndexOf(Array array, object value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static int IndexOf<T>(T[] array, T value)
        {
             throw new NotImplementedException();
        }
        
        
        public static int IndexOf<T>(T[] array, T value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
        {
            //TODO: normal realization
            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
                if (array[i].Equals(value))
                    return i;
            return -1;
        }
        
        
        /// <summary>Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional <see cref="T:System.Array" />.</summary><returns>The index of the last occurrence of <paramref name="value" /> within the entire <paramref name="array" />, if found; otherwise, the lower bound of the array minus 1.</returns><param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to locate in <paramref name="array" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int LastIndexOf(Array array, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional <see cref="T:System.Array" /> that extends from the first element to the specified index.</summary><returns>The index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that extends from the first element to <paramref name="startIndex" />, if found; otherwise, the lower bound of the array minus 1.</returns><param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to locate in <paramref name="array" />.</param><param name="startIndex">The starting index of the backward search.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int LastIndexOf(Array array, object value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional <see cref="T:System.Array" /> that contains the specified number of elements and ends at the specified index.</summary><returns>The index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that contains the number of elements specified in <paramref name="count" /> and ends at <paramref name="startIndex" />, if found; otherwise, the lower bound of the array minus 1.</returns><param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param><param name="value">The object to locate in <paramref name="array" />.</param><param name="startIndex">The starting index of the backward search.</param><param name="count">The number of elements in the section to search.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.-or-<paramref name="count" /> is less than zero.-or-<paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static int LastIndexOf(Array array, object value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public static int LastIndexOf<T>(T[] array, T value)
        {
             throw new NotImplementedException();
        }
        
        
        public static int LastIndexOf<T>(T[] array, T value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reverses the sequence of the elements in the entire one-dimensional <see cref="T:System.Array" />.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> to reverse.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional. </exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Reverse(Array array)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reverses the sequence of the elements in a range of elements in the one-dimensional <see cref="T:System.Array" />.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> to reverse.</param><param name="index">The starting index of the section to reverse.</param><param name="length">The number of elements in the section to reverse.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Reverse(Array array, int index, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts the elements in an entire one-dimensional <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each element of the <see cref="T:System.Array" />.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array array)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each key.</summary><param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param><param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.-or-null to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="keys" /> is null.</exception><exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.-or-The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception><exception cref="T:System.ArgumentException"><paramref name="items" /> is not null, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.</exception><exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array keys, Array items)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts the elements in a range of elements in a one-dimensional <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each element of the <see cref="T:System.Array" />.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param><param name="index">The starting index of the range to sort.</param><param name="length">The number of elements in the range to sort.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception><exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array array, int index, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts a range of elements in a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each key.</summary><param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param><param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.-or-null to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param><param name="index">The starting index of the range to sort.</param><param name="length">The number of elements in the range to sort.</param><exception cref="T:System.ArgumentNullException"><paramref name="keys" /> is null.</exception><exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.-or-The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="keys" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="items" /> is not null, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.-or-<paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.-or-<paramref name="items" /> is not null, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />.</exception><exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array keys, Array items, int index, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts the elements in a one-dimensional <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or-null to use the <see cref="T:System.IComparable" /> implementation of each element.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array array, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary><param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param><param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.-or-null to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or-null to use the <see cref="T:System.IComparable" /> implementation of each element.</param><exception cref="T:System.ArgumentNullException"><paramref name="keys" /> is null.</exception><exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.-or-The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception><exception cref="T:System.ArgumentException"><paramref name="items" /> is not null, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />. -or-The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array keys, Array items, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts the elements in a range of elements in a one-dimensional <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param><param name="index">The starting index of the range to sort.</param><param name="length">The number of elements in the range to sort.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or-null to use the <see cref="T:System.IComparable" /> implementation of each element.</param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null.</exception><exception cref="T:System.RankException"><paramref name="array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />. -or-The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array array, int index, int length, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts a range of elements in a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary><param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param><param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.-or-null to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param><param name="index">The starting index of the range to sort.</param><param name="length">The number of elements in the range to sort.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or-null to use the <see cref="T:System.IComparable" /> implementation of each element.</param><exception cref="T:System.ArgumentNullException"><paramref name="keys" /> is null.</exception><exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.-or-The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="keys" />.-or-<paramref name="length" /> is less than zero.</exception><exception cref="T:System.ArgumentException"><paramref name="items" /> is not null, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.-or-<paramref name="items" /> is not null, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.-or-<paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.-or-<paramref name="items" /> is not null, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />. -or-The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort<T>(T[] array)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort<T>(T[] array, int index, int length)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort<T>(T[] array, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        [SecuritySafeCriticalAttribute()]
        public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.MayCorruptInstance, Cer.MayFail)]
        [SecuritySafeCriticalAttribute()]
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Sort<T>(T[] array, Comparison<T> comparison)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TrueForAll<T>(T[] array, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Initialize()
        {
             throw new NotImplementedException();
        }



        object IList.this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        bool IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        int IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
        {
            throw new NotImplementedException();
        }

        int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
        {
            throw new NotImplementedException();
        }

        int IStructuralComparable.CompareTo(object other, IComparer comparer)
        {
            throw new NotImplementedException();
        }
    }
}
