using System.Diagnostics;
using System.Runtime.InteropServices;
using System;

namespace System.Collections
{
    /// <summary>Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    [ComVisibleAttribute(true)]
    public class SortedList : IDictionary, ICloneable
    {
    
        /// <summary>Gets or sets the capacity of a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain.</returns><exception cref="T:System.ArgumentOutOfRangeException">The value assigned is less than the current number of elements in the <see cref="T:System.Collections.SortedList" /> object.</exception><exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception><filterpriority>2</filterpriority>
        public virtual int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements contained in a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.SortedList" /> object.</returns><filterpriority>1</filterpriority>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the keys in a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>An <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.SortedList" /> object.</returns><filterpriority>1</filterpriority>
        public virtual ICollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the values in a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>An <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.SortedList" /> object.</returns><filterpriority>1</filterpriority>
        public virtual ICollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a <see cref="T:System.Collections.SortedList" /> object is read-only.</summary><returns>true if the <see cref="T:System.Collections.SortedList" /> object is read-only; otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a <see cref="T:System.Collections.SortedList" /> object has a fixed size.</summary><returns>true if the <see cref="T:System.Collections.SortedList" /> object has a fixed size; otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to a <see cref="T:System.Collections.SortedList" /> object is synchronized (thread safe).</summary><returns>true if access to the <see cref="T:System.Collections.SortedList" /> object is synchronized (thread safe); otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.SortedList" /> object.</returns><filterpriority>2</filterpriority>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets and sets the value associated with a specific key in a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The value associated with the <paramref name="key" /> parameter in the <see cref="T:System.Collections.SortedList" /> object, if <paramref name="key" /> is found; otherwise, null.</returns><param name="key">The key associated with the value to get or set. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.SortedList" /> object is read-only.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception><exception cref="T:System.OutOfMemoryException">There is not enough available memory to add the element to the <see cref="T:System.Collections.SortedList" />.</exception><exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception><filterpriority>1</filterpriority>
        public virtual object this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SortedList()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the specified initial capacity, and is sorted according to the <see cref="T:System.IComparable" /> interface implemented by each key added to the <see cref="T:System.Collections.SortedList" /> object.</summary><param name="initialCapacity">The initial number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="initialCapacity" /> is less than zero. </exception><exception cref="T:System.OutOfMemoryException">There is not enough available memory to create a <see cref="T:System.Collections.SortedList" /> object with the specified <paramref name="initialCapacity" />.</exception>
        public SortedList(int initialCapacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the default initial capacity, and is sorted according to the specified <see cref="T:System.Collections.IComparer" /> interface.</summary><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing keys.-or- null to use the <see cref="T:System.IComparable" /> implementation of each key. </param>
        public SortedList(IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the specified initial capacity, and is sorted according to the specified <see cref="T:System.Collections.IComparer" /> interface.</summary><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing keys.-or- null to use the <see cref="T:System.IComparable" /> implementation of each key. </param><param name="capacity">The initial number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero. </exception><exception cref="T:System.OutOfMemoryException">There is not enough available memory to create a <see cref="T:System.Collections.SortedList" /> object with the specified <paramref name="capacity" />.</exception>
        public SortedList(IComparer comparer, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that contains elements copied from the specified dictionary, has the same initial capacity as the number of elements copied, and is sorted according to the <see cref="T:System.IComparable" /> interface implemented by each key.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> implementation to copy to a new <see cref="T:System.Collections.SortedList" /> object.</param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception><exception cref="T:System.InvalidCastException">One or more elements in <paramref name="d" /> do not implement the <see cref="T:System.IComparable" /> interface. </exception>
        public SortedList(IDictionary d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that contains elements copied from the specified dictionary, has the same initial capacity as the number of elements copied, and is sorted according to the specified <see cref="T:System.Collections.IComparer" /> interface.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> implementation to copy to a new <see cref="T:System.Collections.SortedList" /> object.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing keys.-or- null to use the <see cref="T:System.IComparable" /> implementation of each key. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception><exception cref="T:System.InvalidCastException"><paramref name="comparer" /> is null, and one or more elements in <paramref name="d" /> do not implement the <see cref="T:System.IComparable" /> interface. </exception>
        public SortedList(IDictionary d, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an element with the specified key and value to a <see cref="T:System.Collections.SortedList" /> object.</summary><param name="key">The key of the element to add. </param><param name="value">The value of the element to add. The value can be null. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.ArgumentException">An element with the specified <paramref name="key" /> already exists in the <see cref="T:System.Collections.SortedList" /> object.-or- The <see cref="T:System.Collections.SortedList" /> is set to use the <see cref="T:System.IComparable" /> interface, and <paramref name="key" /> does not implement the <see cref="T:System.IComparable" /> interface. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception><exception cref="T:System.OutOfMemoryException">There is not enough available memory to add the element to the <see cref="T:System.Collections.SortedList" />.</exception><exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception><filterpriority>2</filterpriority>
        public virtual void Add(object key, object value)
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
        
        
        /// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific key.</summary><returns>true if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="key" />; otherwise, false.</returns><param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception><filterpriority>1</filterpriority>
        public virtual bool Contains(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific key.</summary><returns>true if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="key" />; otherwise, false.</returns><param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object.</param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception><filterpriority>1</filterpriority>
        public virtual bool ContainsKey(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific value.</summary><returns>true if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="value" />; otherwise, false.</returns><param name="value">The value to locate in the <see cref="T:System.Collections.SortedList" /> object. The value can be null. </param><filterpriority>2</filterpriority>
        public virtual bool ContainsValue(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies <see cref="T:System.Collections.SortedList" /> elements to a one-dimensional <see cref="T:System.Array" /> object, starting at the specified index in the array.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> object that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.SortedList" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="arrayIndex" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.SortedList" /> object is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.SortedList" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(Array array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the value at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The value at the specified index of the <see cref="T:System.Collections.SortedList" /> object.</returns><param name="index">The zero-based index of the value to get. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object. </exception><filterpriority>2</filterpriority>
        public virtual object GetByIndex(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the key at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The key at the specified index of the <see cref="T:System.Collections.SortedList" /> object.</returns><param name="index">The zero-based index of the key to get. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object.</exception><filterpriority>2</filterpriority>
        public virtual object GetKey(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IList GetKeyList()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IList GetValueList()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the zero-based index of the specified key in a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The zero-based index of the <paramref name="key" /> parameter, if <paramref name="key" /> is found in the <see cref="T:System.Collections.SortedList" /> object; otherwise, -1.</returns><param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.InvalidOperationException">The comparer throws an exception. </exception><filterpriority>1</filterpriority>
        public virtual int IndexOfKey(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the zero-based index of the first occurrence of the specified value in a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>The zero-based index of the first occurrence of the <paramref name="value" /> parameter, if <paramref name="value" /> is found in the <see cref="T:System.Collections.SortedList" /> object; otherwise, -1.</returns><param name="value">The value to locate in the <see cref="T:System.Collections.SortedList" /> object. The value can be null. </param><filterpriority>1</filterpriority>
        public virtual int IndexOfValue(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary><param name="index">The zero-based index of the element to remove. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception><filterpriority>2</filterpriority>
        public virtual void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element with the specified key from a <see cref="T:System.Collections.SortedList" /> object.</summary><param name="key">The key of the element to remove. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> object is read-only.-or- The <see cref="T:System.Collections.SortedList" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual void Remove(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the value at a specific index in a <see cref="T:System.Collections.SortedList" /> object.</summary><param name="index">The zero-based index at which to save <paramref name="value" />. </param><param name="value">The <see cref="T:System.Object" /> to save into the <see cref="T:System.Collections.SortedList" /> object. The value can be null. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object. </exception><filterpriority>2</filterpriority>
        public virtual void SetByIndex(int index, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a synchronized (thread-safe) wrapper for a <see cref="T:System.Collections.SortedList" /> object.</summary><returns>A synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.SortedList" /> object.</returns><param name="list">The <see cref="T:System.Collections.SortedList" /> object to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="list" /> is null. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static SortedList Synchronized(SortedList list)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void TrimToSize()
        {
             throw new NotImplementedException();
        }



        object IDictionary.this[object key]
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

        ICollection IDictionary.Keys
        {
            get { throw new NotImplementedException(); }
        }

        ICollection IDictionary.Values
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.Contains(object key)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Clear()
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void IDictionary.Remove(object key)
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
    }
}
