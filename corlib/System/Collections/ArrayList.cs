using System.Runtime.InteropServices;
using System.Diagnostics;
using System;
using System.Security;

namespace System.Collections
{
    /// <summary>Implements the <see cref="T:System.Collections.IList" /> interface using an array whose size is dynamically increased as required.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class ArrayList : IList, ICloneable
    {
    
        /// <summary>Gets or sets the number of elements that the <see cref="T:System.Collections.ArrayList" /> can contain.</summary><returns>The number of elements that the <see cref="T:System.Collections.ArrayList" /> can contain.</returns><exception cref="T:System.ArgumentOutOfRangeException"><see cref="P:System.Collections.ArrayList.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.ArrayList.Count" />.</exception><exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception><filterpriority>1</filterpriority>
        public virtual int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements actually contained in the <see cref="T:System.Collections.ArrayList" />.</summary><returns>The number of elements actually contained in the <see cref="T:System.Collections.ArrayList" />.</returns><filterpriority>1</filterpriority>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.ArrayList" /> has a fixed size.</summary><returns>true if the <see cref="T:System.Collections.ArrayList" /> has a fixed size; otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.ArrayList" /> is read-only.</summary><returns>true if the <see cref="T:System.Collections.ArrayList" /> is read-only; otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ArrayList" /> is synchronized (thread safe).</summary><returns>true if access to the <see cref="T:System.Collections.ArrayList" /> is synchronized (thread safe); otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ArrayList" />.</summary><returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ArrayList" />.</returns><filterpriority>2</filterpriority>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the element at the specified index.</summary><returns>The element at the specified index.</returns><param name="index">The zero-based index of the element to get or set. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception><filterpriority>1</filterpriority>
        public virtual object this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ArrayList()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that is empty and has the specified initial capacity.</summary><param name="capacity">The number of elements that the new list can initially store. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero. </exception>
        public ArrayList(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.</summary><param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements are copied to the new list. </param><exception cref="T:System.ArgumentNullException"><paramref name="c" /> is null. </exception>
        public ArrayList(ICollection c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an <see cref="T:System.Collections.ArrayList" /> wrapper for a specific <see cref="T:System.Collections.IList" />.</summary><returns>The <see cref="T:System.Collections.ArrayList" /> wrapper around the <see cref="T:System.Collections.IList" />.</returns><param name="list">The <see cref="T:System.Collections.IList" /> to wrap.</param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null.</exception><filterpriority>2</filterpriority>
        public static ArrayList Adapter(IList list)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an object to the end of the <see cref="T:System.Collections.ArrayList" />.</summary><returns>The <see cref="T:System.Collections.ArrayList" /> index at which the <paramref name="value" /> has been added.</returns><param name="value">The <see cref="T:System.Object" /> to be added to the end of the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual int Add(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the elements of an <see cref="T:System.Collections.ICollection" /> to the end of the <see cref="T:System.Collections.ArrayList" />.</summary><param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements should be added to the end of the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be null, but it can contain elements that are null. </param><exception cref="T:System.ArgumentNullException"><paramref name="c" /> is null. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual void AddRange(ICollection c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches a range of elements in the sorted <see cref="T:System.Collections.ArrayList" /> for an element using the specified comparer and returns the zero-based index of the element.</summary><returns>The zero-based index of <paramref name="value" /> in the sorted <see cref="T:System.Collections.ArrayList" />, if <paramref name="value" /> is found; otherwise, a negative number, which is the bitwise complement of the index of the next element that is larger than <paramref name="value" /> or, if there is no larger element, the bitwise complement of <see cref="P:System.Collections.ArrayList.Count" />.</returns><param name="index">The zero-based starting index of the range to search. </param><param name="count">The length of the range to search. </param><param name="value">The <see cref="T:System.Object" /> to locate. The value can be null. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- null to use the default comparer that is the <see cref="T:System.IComparable" /> implementation of each element. </param><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range in the <see cref="T:System.Collections.ArrayList" />.-or- <paramref name="comparer" /> is null and neither <paramref name="value" /> nor the elements of <see cref="T:System.Collections.ArrayList" /> implement the <see cref="T:System.IComparable" /> interface. </exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null and <paramref name="value" /> is not of the same type as the elements of the <see cref="T:System.Collections.ArrayList" />. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><filterpriority>1</filterpriority>
        public virtual int BinarySearch(int index, int count, object value, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches the entire sorted <see cref="T:System.Collections.ArrayList" /> for an element using the default comparer and returns the zero-based index of the element.</summary><returns>The zero-based index of <paramref name="value" /> in the sorted <see cref="T:System.Collections.ArrayList" />, if <paramref name="value" /> is found; otherwise, a negative number, which is the bitwise complement of the index of the next element that is larger than <paramref name="value" /> or, if there is no larger element, the bitwise complement of <see cref="P:System.Collections.ArrayList.Count" />.</returns><param name="value">The <see cref="T:System.Object" /> to locate. The value can be null. </param><exception cref="T:System.ArgumentException">Neither <paramref name="value" /> nor the elements of <see cref="T:System.Collections.ArrayList" /> implement the <see cref="T:System.IComparable" /> interface. </exception><exception cref="T:System.InvalidOperationException"><paramref name="value" /> is not of the same type as the elements of the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>1</filterpriority>
        public virtual int BinarySearch(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches the entire sorted <see cref="T:System.Collections.ArrayList" /> for an element using the specified comparer and returns the zero-based index of the element.</summary><returns>The zero-based index of <paramref name="value" /> in the sorted <see cref="T:System.Collections.ArrayList" />, if <paramref name="value" /> is found; otherwise, a negative number, which is the bitwise complement of the index of the next element that is larger than <paramref name="value" /> or, if there is no larger element, the bitwise complement of <see cref="P:System.Collections.ArrayList.Count" />.</returns><param name="value">The <see cref="T:System.Object" /> to locate. The value can be null. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- null to use the default comparer that is the <see cref="T:System.IComparable" /> implementation of each element. </param><exception cref="T:System.ArgumentException"><paramref name="comparer" /> is null and neither <paramref name="value" /> nor the elements of <see cref="T:System.Collections.ArrayList" /> implement the <see cref="T:System.IComparable" /> interface. </exception><exception cref="T:System.InvalidOperationException"><paramref name="comparer" /> is null and <paramref name="value" /> is not of the same type as the elements of the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>1</filterpriority>
        public virtual int BinarySearch(object value, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether an element is in the <see cref="T:System.Collections.ArrayList" />.</summary><returns>true if <paramref name="item" /> is found in the <see cref="T:System.Collections.ArrayList" />; otherwise, false.</returns><param name="item">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><filterpriority>1</filterpriority>
        public virtual bool Contains(object item)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the entire <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the beginning of the target array.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.ArrayList" /> is greater than the number of elements that the destination <paramref name="array" /> can contain. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(Array array)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the entire <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="arrayIndex" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.ArrayList" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(Array array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies a range of elements from the <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary><param name="index">The zero-based index in the source <see cref="T:System.Collections.ArrayList" /> at which copying begins. </param><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param><param name="count">The number of elements to copy. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="arrayIndex" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- <paramref name="index" /> is equal to or greater than the <see cref="P:System.Collections.ArrayList.Count" /> of the source <see cref="T:System.Collections.ArrayList" />.-or- The number of elements from <paramref name="index" /> to the end of the source <see cref="T:System.Collections.ArrayList" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an <see cref="T:System.Collections.IList" /> wrapper with a fixed size.</summary><returns>An <see cref="T:System.Collections.IList" /> wrapper with a fixed size.</returns><param name="list">The <see cref="T:System.Collections.IList" /> to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>2</filterpriority>
        public static IList FixedSize(IList list)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an <see cref="T:System.Collections.ArrayList" /> wrapper with a fixed size.</summary><returns>An <see cref="T:System.Collections.ArrayList" /> wrapper with a fixed size.</returns><param name="list">The <see cref="T:System.Collections.ArrayList" /> to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>2</filterpriority>
        public static ArrayList FixedSize(ArrayList list)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerator for a range of elements in the <see cref="T:System.Collections.ArrayList" />.</summary><returns>An <see cref="T:System.Collections.IEnumerator" /> for the specified range of elements in the <see cref="T:System.Collections.ArrayList" />.</returns><param name="index">The zero-based starting index of the <see cref="T:System.Collections.ArrayList" /> section that the enumerator should refer to. </param><param name="count">The number of elements in the <see cref="T:System.Collections.ArrayList" /> section that the enumerator should refer to. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>2</filterpriority>
        public virtual IEnumerator GetEnumerator(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.ArrayList" />.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" /> within the entire <see cref="T:System.Collections.ArrayList" />, if found; otherwise, -1.</returns><param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><filterpriority>1</filterpriority>
        public virtual int IndexOf(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that extends from the specified index to the last element.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" /> within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that extends from <paramref name="startIndex" /> to the last element, if found; otherwise, -1.</returns><param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty list.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>1</filterpriority>
        public virtual int IndexOf(object value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that starts at the specified index and contains the specified number of elements.</summary><returns>The zero-based index of the first occurrence of <paramref name="value" /> within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that starts at <paramref name="startIndex" /> and contains <paramref name="count" /> number of elements, if found; otherwise, -1.</returns><param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty list.</param><param name="count">The number of elements in the section to search. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for the <see cref="T:System.Collections.ArrayList" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>1</filterpriority>
        public virtual int IndexOf(object value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Inserts an element into the <see cref="T:System.Collections.ArrayList" /> at the specified index.</summary><param name="index">The zero-based index at which <paramref name="value" /> should be inserted. </param><param name="value">The <see cref="T:System.Object" /> to insert. The value can be null. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual void Insert(int index, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Inserts the elements of a collection into the <see cref="T:System.Collections.ArrayList" /> at the specified index.</summary><param name="index">The zero-based index at which the new elements should be inserted. </param><param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements should be inserted into the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be null, but it can contain elements that are null. </param><exception cref="T:System.ArgumentNullException"><paramref name="c" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>2</filterpriority>
        public virtual void InsertRange(int index, ICollection c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the last occurrence within the entire <see cref="T:System.Collections.ArrayList" />.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" /> within the entire the <see cref="T:System.Collections.ArrayList" />, if found; otherwise, -1.</returns><param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><filterpriority>2</filterpriority>
        public virtual int LastIndexOf(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the last occurrence within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that extends from the first element to the specified index.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" /> within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that extends from the first element to <paramref name="startIndex" />, if found; otherwise, -1.</returns><param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><param name="startIndex">The zero-based starting index of the backward search. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>2</filterpriority>
        public virtual int LastIndexOf(object value, int startIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the last occurrence within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that contains the specified number of elements and ends at the specified index.</summary><returns>The zero-based index of the last occurrence of <paramref name="value" /> within the range of elements in the <see cref="T:System.Collections.ArrayList" /> that contains <paramref name="count" /> number of elements and ends at <paramref name="startIndex" />, if found; otherwise, -1.</returns><param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><param name="startIndex">The zero-based starting index of the backward search. </param><param name="count">The number of elements in the section to search. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> is outside the range of valid indexes for the <see cref="T:System.Collections.ArrayList" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>2</filterpriority>
        public virtual int LastIndexOf(object value, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a read-only <see cref="T:System.Collections.IList" /> wrapper.</summary><returns>A read-only <see cref="T:System.Collections.IList" /> wrapper around <paramref name="list" />.</returns><param name="list">The <see cref="T:System.Collections.IList" /> to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>2</filterpriority>
        public static IList ReadOnly(IList list)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a read-only <see cref="T:System.Collections.ArrayList" /> wrapper.</summary><returns>A read-only <see cref="T:System.Collections.ArrayList" /> wrapper around <paramref name="list" />.</returns><param name="list">The <see cref="T:System.Collections.ArrayList" /> to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>2</filterpriority>
        public static ArrayList ReadOnly(ArrayList list)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.ArrayList" />.</summary><param name="obj">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual void Remove(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ArrayList" />.</summary><param name="index">The zero-based index of the element to remove. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes a range of elements from the <see cref="T:System.Collections.ArrayList" />.</summary><param name="index">The zero-based starting index of the range of elements to remove. </param><param name="count">The number of elements to remove. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.ArrayList" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.-or- The <see cref="T:System.Collections.ArrayList" /> has a fixed size. </exception><filterpriority>2</filterpriority>
        public virtual void RemoveRange(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an <see cref="T:System.Collections.ArrayList" /> whose elements are copies of the specified value.</summary><returns>An <see cref="T:System.Collections.ArrayList" /> with <paramref name="count" /> number of elements, all of which are copies of <paramref name="value" />.</returns><param name="value">The <see cref="T:System.Object" /> to copy multiple times in the new <see cref="T:System.Collections.ArrayList" />. The value can be null. </param><param name="count">The number of times <paramref name="value" /> should be copied. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count" /> is less than zero. </exception><filterpriority>2</filterpriority>
        public static ArrayList Repeat(object value, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Reverse()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reverses the order of the elements in the specified range.</summary><param name="index">The zero-based starting index of the range to reverse. </param><param name="count">The number of elements in the range to reverse. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.ArrayList" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only. </exception><filterpriority>2</filterpriority>
        public virtual void Reverse(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the elements of a collection over a range of elements in the <see cref="T:System.Collections.ArrayList" />.</summary><param name="index">The zero-based <see cref="T:System.Collections.ArrayList" /> index at which to start copying the elements of <paramref name="c" />. </param><param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements to copy to the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be null, but it can contain elements that are null. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="index" /> plus the number of elements in <paramref name="c" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="c" /> is null. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only. </exception><filterpriority>2</filterpriority>
        public virtual void SetRange(int index, ICollection c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an <see cref="T:System.Collections.ArrayList" /> which represents a subset of the elements in the source <see cref="T:System.Collections.ArrayList" />.</summary><returns>An <see cref="T:System.Collections.ArrayList" /> which represents a subset of the elements in the source <see cref="T:System.Collections.ArrayList" />.</returns><param name="index">The zero-based <see cref="T:System.Collections.ArrayList" /> index at which the range starts. </param><param name="count">The number of elements in the range. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.ArrayList" />. </exception><filterpriority>2</filterpriority>
        public virtual ArrayList GetRange(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Sort()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts the elements in the entire <see cref="T:System.Collections.ArrayList" /> using the specified comparer.</summary><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- A null reference (Nothing in Visual Basic) to use the <see cref="T:System.IComparable" /> implementation of each element. </param><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only. </exception><exception cref="T:System.InvalidOperationException">An error occurred while comparing two elements.</exception><filterpriority>1</filterpriority>
        public virtual void Sort(IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sorts the elements in a range of elements in <see cref="T:System.Collections.ArrayList" /> using the specified comparer.</summary><param name="index">The zero-based starting index of the range to sort. </param><param name="count">The length of the range to sort. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.-or- A null reference (Nothing in Visual Basic) to use the <see cref="T:System.IComparable" /> implementation of each element. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or- <paramref name="count" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the <see cref="T:System.Collections.ArrayList" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only. </exception><exception cref="T:System.InvalidOperationException">An error occurred while comparing two elements.</exception><filterpriority>1</filterpriority>
        public virtual void Sort(int index, int count, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an <see cref="T:System.Collections.IList" /> wrapper that is synchronized (thread safe).</summary><returns>An <see cref="T:System.Collections.IList" /> wrapper that is synchronized (thread safe).</returns><param name="list">The <see cref="T:System.Collections.IList" /> to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>2</filterpriority>
        public static IList Synchronized(IList list)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an <see cref="T:System.Collections.ArrayList" /> wrapper that is synchronized (thread safe).</summary><returns>An <see cref="T:System.Collections.ArrayList" /> wrapper that is synchronized (thread safe).</returns><param name="list">The <see cref="T:System.Collections.ArrayList" /> to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>2</filterpriority>
        public static ArrayList Synchronized(ArrayList list)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the elements of the <see cref="T:System.Collections.ArrayList" /> to a new array of the specified element type.</summary><returns>An array of the specified element type containing copies of the elements of the <see cref="T:System.Collections.ArrayList" />.</returns><param name="type">The element <see cref="T:System.Type" /> of the destination array to create and copy elements to.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the specified type. </exception><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public virtual Array ToArray(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void TrimToSize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
