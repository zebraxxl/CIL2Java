using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.CompilerServices;
using System;

namespace System.Collections.Concurrent
{
    /// <summary>Represents a thread-safe collection of key-value pairs that can be accessed by multiple threads concurrently. </summary><typeparam name="TKey">The type of the values in the dictionary.</typeparam><typeparam name="TValue">The type of the keys in the dictionary.</typeparam>
    [Serializable]
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
    {
    
        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary><returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns><exception cref="T:System.OverflowException">The dictionary already contains the maximum number of elements, <see cref="F:System.Int32.MaxValue" />.</exception>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> is empty.</summary><returns>true if the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> is empty; otherwise, false.</returns>
        public bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary><returns>A <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
        public ICollection<TKey> Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection containing the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary><returns>A <see cref="T:System.Collections.Generic.ICollection`1" /> containing the values in the <see cref="T:System.Collections.Generic.Dictionary`2" /></returns>
        public ICollection<TValue> Values
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ConcurrentDictionary()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> class that is empty, has the specified concurrency level and capacity, and uses the default comparer for the key type.</summary><param name="concurrencyLevel">The estimated number of threads that will update the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> concurrently.</param><param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> can contain.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="concurrencyLevel" /> is less than 1.-or-<paramref name="capacity" /> is less than 0.</exception>
        public ConcurrentDictionary(int concurrencyLevel, int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryAdd(TKey key, TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ContainsKey(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryRemove(TKey key, ref TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryGetValue(TKey key, ref TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public KeyValuePair<TKey, TValue>[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
        {
             throw new NotImplementedException();
        }
        
        
        public TValue GetOrAdd(TKey key, TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
        {
             throw new NotImplementedException();
        }
        
        
        public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
        {
             throw new NotImplementedException();
        }



        TValue IDictionary<TKey, TValue>.this[TKey key]
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

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get { throw new NotImplementedException(); }
        }

        ICollection<TValue> IDictionary<TKey, TValue>.Values
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        int ICollection<KeyValuePair<TKey, TValue>>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
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
    }
}
