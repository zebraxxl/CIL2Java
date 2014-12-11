using System.Collections.Generic;

namespace System
{
    /// <summary>Delimits a section of a one-dimensional array.</summary><typeparam name="T">The type of the elements in the array segment.</typeparam><filterpriority>2</filterpriority>
    [Serializable]
    public struct ArraySegment<T> : IList<T>, IReadOnlyList<T>
    {
    
        /// <summary>Gets the original array containing the range of elements that the array segment delimits.</summary><returns>The original array that was passed to the constructor, and that contains the range delimited by the <see cref="T:System.ArraySegment`1" />.</returns><filterpriority>1</filterpriority>
        public T[] Array
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the position of the first element in the range delimited by the array segment, relative to the start of the original array.</summary><returns>The position of the first element in the range delimited by the <see cref="T:System.ArraySegment`1" />, relative to the start of the original array.</returns><filterpriority>1</filterpriority>
        public int Offset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements in the range delimited by the array segment.</summary><returns>The number of elements in the range delimited by the <see cref="T:System.ArraySegment`1" />.</returns><filterpriority>1</filterpriority>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ArraySegment(T[] array)
        {
             throw new NotImplementedException();
        }
        
        
        public ArraySegment(T[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object is equal to the current instance.</summary><returns>true if the specified object is a <see cref="T:System.ArraySegment`1" /> structure and is equal to the current instance; otherwise, false.</returns><param name="obj">The object to be compared with the current instance.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(ArraySegment<T> obj)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(ArraySegment<T> a, ArraySegment<T> b)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(ArraySegment<T> a, ArraySegment<T> b)
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

        int ICollection<T>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
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

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        T IReadOnlyList<T>.this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        int IReadOnlyCollection<T>.Count
        {
            get { throw new NotImplementedException(); }
        }
    }
}
