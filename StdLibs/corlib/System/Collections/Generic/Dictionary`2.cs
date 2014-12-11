using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.Serialization;
using System;
using System.Security;

namespace System.Collections.Generic
{
    /// <summary>Represents a collection of keys and values.</summary><typeparam name="TKey">The type of the keys in the dictionary.</typeparam><typeparam name="TValue">The type of the values in the dictionary.</typeparam><filterpriority>1</filterpriority>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    [ComVisibleAttribute(false)]
    public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>, ISerializable, IDeserializationCallback
    {
        [Serializable]
        public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator
        {
        
            public KeyValuePair<TKey, TValue> Current
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public bool MoveNext()
            {
                 throw new NotImplementedException();
            }
            
            
            public void Dispose()
            {
                 throw new NotImplementedException();
            }



            KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
            {
                get { throw new NotImplementedException(); }
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }

            object IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            object IDictionaryEnumerator.Key
            {
                get { throw new NotImplementedException(); }
            }

            object IDictionaryEnumerator.Value
            {
                get { throw new NotImplementedException(); }
            }

            DictionaryEntry IDictionaryEnumerator.Entry
            {
                get { throw new NotImplementedException(); }
            }
        }
    
        [Serializable]
        [DebuggerDisplayAttribute("Count = {Count}")]
        public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, ICollection
        {
            [Serializable]
            public struct Enumerator : IEnumerator<TKey>
            {
            
                public TKey Current
                {
                    get { throw new NotImplementedException(); }
                }
            
            
                public void Dispose()
                {
                     throw new NotImplementedException();
                }
                
                
                public bool MoveNext()
                {
                     throw new NotImplementedException();
                }



                TKey IEnumerator<TKey>.Current
                {
                    get { throw new NotImplementedException(); }
                }

                void IDisposable.Dispose()
                {
                    throw new NotImplementedException();
                }

                object IEnumerator.Current
                {
                    get { throw new NotImplementedException(); }
                }

                bool IEnumerator.MoveNext()
                {
                    throw new NotImplementedException();
                }

                void IEnumerator.Reset()
                {
                    throw new NotImplementedException();
                }
            }
        
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public KeyCollection(Dictionary<TKey, TValue> dictionary)
            {
                 throw new NotImplementedException();
            }
            
            
            public Enumerator GetEnumerator()
            {
                 throw new NotImplementedException();
            }
            
            
            public void CopyTo(TKey[] array, int index)
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
            [Serializable]
            public struct Enumerator : IEnumerator<TValue>
            {
            
                public TValue Current
                {
                    get { throw new NotImplementedException(); }
                }
            
            
                public void Dispose()
                {
                     throw new NotImplementedException();
                }
                
                
                public bool MoveNext()
                {
                     throw new NotImplementedException();
                }



                TValue IEnumerator<TValue>.Current
                {
                    get { throw new NotImplementedException(); }
                }

                void IDisposable.Dispose()
                {
                    throw new NotImplementedException();
                }

                object IEnumerator.Current
                {
                    get { throw new NotImplementedException(); }
                }

                bool IEnumerator.MoveNext()
                {
                    throw new NotImplementedException();
                }

                void IEnumerator.Reset()
                {
                    throw new NotImplementedException();
                }
            }
        
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public ValueCollection(Dictionary<TKey, TValue> dictionary)
            {
                 throw new NotImplementedException();
            }
            
            
            public Enumerator GetEnumerator()
            {
                 throw new NotImplementedException();
            }
            
            
            public void CopyTo(TValue[] array, int index)
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
    
    
        /// <summary>Gets the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> that is used to determine equality of keys for the dictionary. </summary><returns>The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface implementation that is used to determine equality of keys for the current <see cref="T:System.Collections.Generic.Dictionary`2" /> and to provide hash values for the keys.</returns>
        public IEqualityComparer<TKey> Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary><returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary><returns>A <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> containing the keys in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
        public KeyCollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection containing the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary><returns>A <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> containing the values in the <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
        public ValueCollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public Dictionary()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class that is empty, has the specified initial capacity, and uses the default equality comparer for the key type.</summary><param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Generic.Dictionary`2" /> can contain.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than 0.</exception>
        public Dictionary(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public Dictionary(IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public Dictionary(IDictionary<TKey, TValue> dictionary)
        {
             throw new NotImplementedException();
        }
        
        
        public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.Dictionary`2" /> class with serialized data.</summary><param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Generic.Dictionary`2" />.</param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
        protected Dictionary(SerializationInfo info, StreamingContext context)
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
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Generic.Dictionary`2" /> instance.</summary><param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Collections.Generic.Dictionary`2" /> instance.</param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Generic.Dictionary`2" /> instance.</param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary><param name="sender">The source of the deserialization event.</param><exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Generic.Dictionary`2" /> instance is invalid.</exception>
        public virtual void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryGetValue(TKey key, ref TValue value)
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

        bool IDictionary<TKey, TValue>.TryGetValue(TKey key, ref TValue value)
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

        bool IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey key, ref TValue value)
        {
            throw new NotImplementedException();
        }

        int IReadOnlyCollection<KeyValuePair<TKey, TValue>>.Count
        {
            get { throw new NotImplementedException(); }
        }
    }
}
