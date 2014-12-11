using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace System.Runtime.CompilerServices
{
    [Serializable]
    public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, IList
    {
    
        public int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ReadOnlyCollectionBuilder()
        {
             throw new NotImplementedException();
        }
        
        
        public ReadOnlyCollectionBuilder(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public ReadOnlyCollectionBuilder(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(T item)
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
        
        
        public IEnumerator<T> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reverse()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reverse(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public T[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public ReadOnlyCollection<T> ToReadOnlyCollection()
        {
             throw new NotImplementedException();
        }



        int IList<T>.IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        void IList<T>.Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        void IList<T>.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        T IList<T>.this[int index]
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

        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
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

        bool IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
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
