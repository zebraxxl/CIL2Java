using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;

namespace System.Collections.ObjectModel
{
    /// <summary>Represents a read-only, generic collection of key/value pairs.</summary><typeparam name="TKey">The type of keys in the dictionary.</typeparam><typeparam name="TValue">The type of values in the dictionary.</typeparam>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>
    {
        [Serializable]
        [DebuggerDisplayAttribute("Count = {Count}")]
        public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, ICollection
        {
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public void CopyTo(TKey[] array, int arrayIndex)
            {
                 throw new NotImplementedException();
            }
            
            
            public IEnumerator<TKey> GetEnumerator()
            {
                 throw new NotImplementedException();
            }



            int ICollection<TKey>.Count
            {
                get { throw new NotImplementedException(); }
            }

            bool ICollection<TKey>.IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }

            void ICollection<TKey>.Add(TKey item)
            {
                throw new NotImplementedException();
            }

            void ICollection<TKey>.Clear()
            {
                throw new NotImplementedException();
            }

            bool ICollection<TKey>.Contains(TKey item)
            {
                throw new NotImplementedException();
            }

            void ICollection<TKey>.CopyTo(TKey[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            bool ICollection<TKey>.Remove(TKey item)
            {
                throw new NotImplementedException();
            }

            IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
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
    
        [Serializable]
        [DebuggerDisplayAttribute("Count = {Count}")]
        public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, ICollection
        {
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public void CopyTo(TValue[] array, int arrayIndex)
            {
                 throw new NotImplementedException();
            }
            
            
            public IEnumerator<TValue> GetEnumerator()
            {
                 throw new NotImplementedException();
            }



            int ICollection<TValue>.Count
            {
                get { throw new NotImplementedException(); }
            }

            bool ICollection<TValue>.IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }

            void ICollection<TValue>.Add(TValue item)
            {
                throw new NotImplementedException();
            }

            void ICollection<TValue>.Clear()
            {
                throw new NotImplementedException();
            }

            bool ICollection<TValue>.Contains(TValue item)
            {
                throw new NotImplementedException();
            }

            void ICollection<TValue>.CopyTo(TValue[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            bool ICollection<TValue>.Remove(TValue item)
            {
                throw new NotImplementedException();
            }

            IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
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
    
    
        /// <summary>Gets the dictionary that is wrapped by this <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> object.</summary><returns>The dictionary that is wrapped by this object.</returns>
        protected IDictionary<TKey, TValue> Dictionary
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a key collection that contains the keys of the dictionary.</summary><returns>A key collection that contains the keys of the dictionary.</returns>
        public KeyCollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection that contains the values in the dictionary.</summary><returns>A collection that contains the values in the object that implements <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</returns>
        public ValueCollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of items in the dictionary.</summary><returns>The number of items in the dictionary.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ContainsKey(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryGetValue(TKey key, out TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
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

        TValue IReadOnlyDictionary<TKey, TValue>.this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
        {
            get { throw new NotImplementedException(); }
        }

        bool IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        bool IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        int IReadOnlyCollection<KeyValuePair<TKey, TValue>>.Count
        {
            get { throw new NotImplementedException(); }
        }
    }
}
