using System.Diagnostics;
using System.Runtime.Serialization;
using System;
using System.Security;

namespace System.Collections.Generic
{
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class HashSet<T> : ISerializable, IDeserializationCallback, ISet<T>
    {
        [Serializable]
        public struct Enumerator : IEnumerator<T>
        {
        
            public T Current
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



            T IEnumerator<T>.Current
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
    
        public IEqualityComparer<T> Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HashSet()
        {
             throw new NotImplementedException();
        }
        
        
        public HashSet(IEqualityComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public HashSet(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected HashSet(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Add(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void UnionWith(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public void IntersectWith(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public void ExceptWith(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public void SymmetricExceptWith(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsSubsetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsSupersetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Overlaps(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SetEquals(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int arrayIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public int RemoveWhere(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public void TrimExcess()
        {
             throw new NotImplementedException();
        }
        
        
        public static IEqualityComparer<HashSet<T>> CreateSetComparer()
        {
             throw new NotImplementedException();
        }



        bool ISet<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.SetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<T>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
