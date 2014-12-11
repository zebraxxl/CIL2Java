using System.Diagnostics;
using System.Collections;
using System.Runtime.Serialization;
using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Collections.Generic
{
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class SortedSet<T> : ISet<T>, ICollection, ISerializable, IDeserializationCallback
    {
        [Serializable]
        public struct Enumerator : IEnumerator<T>, ISerializable, IDeserializationCallback
        {
        
            public T Current
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

            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            void IDeserializationCallback.OnDeserialization(object sender)
            {
                throw new NotImplementedException();
            }
        }
    
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public IComparer<T> Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
        public T Min
        {
            get { throw new NotImplementedException(); }
        }
    
        public T Max
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SortedSet()
        {
             throw new NotImplementedException();
        }
        
        
        public SortedSet(IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedSet(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public SortedSet(IEnumerable<T> collection, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected SortedSet(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Add(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Contains(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public static IEqualityComparer<SortedSet<T>> CreateSetComparer()
        {
             throw new NotImplementedException();
        }
        
        
        public static IEqualityComparer<SortedSet<T>> CreateSetComparer(IEqualityComparer<T> memberEqualityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        public void UnionWith(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void IntersectWith(IEnumerable<T> other)
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
        
        
        [SecuritySafeCriticalAttribute()]
        public bool IsSubsetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsSupersetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool SetEquals(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Overlaps(IEnumerable<T> other)
        {
             throw new NotImplementedException();
        }
        
        
        public int RemoveWhere(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<T> Reverse()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }



        bool ISet<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ISet<T>.SymmetricExceptWith(IEnumerable<T> other)
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

        bool ISet<T>.IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        bool ISet<T>.IsProperSubsetOf(IEnumerable<T> other)
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

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
