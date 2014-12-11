using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections;

namespace System.Collections.Generic
{
    [Serializable]
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
    {
    
        public int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public IComparer<TKey> Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<TKey> Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<TValue> Values
        {
            get { throw new NotImplementedException(); }
        }
    
        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SortedList()
        {
             throw new NotImplementedException();
        }
        
        
        public SortedList(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedList(IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedList(int capacity, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedList(IDictionary<TKey, TValue> dictionary)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedList(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(TKey key, TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool ContainsKey(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ContainsValue(TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOfKey(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOfValue(TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryGetValue(TKey key, ref TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public void TrimExcess()
        {
             throw new NotImplementedException();
        }



        void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        ICollection<TValue> IDictionary<TKey, TValue>.Values
        {
            get { throw new NotImplementedException(); }
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

        int ICollection<KeyValuePair<TKey, TValue>>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
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

        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Clear()
        {
            throw new NotImplementedException();
        }

        bool IDictionary.Contains(object key)
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        ICollection IDictionary.Keys
        {
            get { throw new NotImplementedException(); }
        }

        void IDictionary.Remove(object key)
        {
            throw new NotImplementedException();
        }

        ICollection IDictionary.Values
        {
            get { throw new NotImplementedException(); }
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

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    }
}
