using System.Diagnostics;
using System.Collections;
using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary
    {
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

            DictionaryEntry IDictionaryEnumerator.Entry
            {
                get { throw new NotImplementedException(); }
            }

            object IDictionaryEnumerator.Key
            {
                get { throw new NotImplementedException(); }
            }

            object IDictionaryEnumerator.Value
            {
                get { throw new NotImplementedException(); }
            }
        }
    
        [Serializable]
        [DebuggerDisplayAttribute("Count = {Count}")]
        public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, ICollection
        {
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
        
        
            public KeyCollection(SortedDictionary<TKey, TValue> dictionary)
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

            int ICollection<TKey>.Count
            {
                get { throw new NotImplementedException(); }
            }

            bool ICollection<TKey>.IsReadOnly
            {
                get { throw new NotImplementedException(); }
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
    
        [Serializable]
        [DebuggerDisplayAttribute("Count = {Count}")]
        public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, ICollection
        {
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
        
        
            public ValueCollection(SortedDictionary<TKey, TValue> dictionary)
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

            int ICollection<TValue>.Count
            {
                get { throw new NotImplementedException(); }
            }

            bool ICollection<TValue>.IsReadOnly
            {
                get { throw new NotImplementedException(); }
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
    
    
        public TValue this[TKey key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public IComparer<TKey> Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
        public KeyCollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        public ValueCollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SortedDictionary()
        {
             throw new NotImplementedException();
        }
        
        
        public SortedDictionary(IDictionary<TKey, TValue> dictionary)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedDictionary(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedDictionary(IComparer<TKey> comparer)
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


        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
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
