using System.Diagnostics;
using System.Collections;
using System;
using System.Collections.ObjectModel;

namespace System.Collections.Generic
{
    /// <summary>Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.</summary><typeparam name="T">The type of elements in the list.</typeparam><filterpriority>1</filterpriority>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class List<T> : IList<T>, IList, IReadOnlyList<T>
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
    
    
        /// <summary>Gets or sets the total number of elements the internal data structure can hold without resizing.</summary><returns>The number of elements that the <see cref="T:System.Collections.Generic.List`1" /> can contain before resizing is required.</returns><exception cref="T:System.ArgumentOutOfRangeException"><see cref="P:System.Collections.Generic.List`1.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.Generic.List`1.Count" />. </exception><exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
        public int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements actually contained in the <see cref="T:System.Collections.Generic.List`1" />.</summary><returns>The number of elements actually contained in the <see cref="T:System.Collections.Generic.List`1" />.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the element at the specified index.</summary><returns>The element at the specified index.</returns><param name="index">The zero-based index of the element to get or set.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />. </exception>
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public List()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.List`1" /> class that is empty and has the specified initial capacity.</summary><param name="capacity">The number of elements that the new list can initially store.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than 0. </exception>
        public List(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public List(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public ReadOnlyCollection<T> AsReadOnly()
        {
             throw new NotImplementedException();
        }
        
        
        public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public int BinarySearch(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public int BinarySearch(T item, IComparer<T> comparer)
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
        
        
        public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(int index, T[] array, int arrayIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Exists(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public T Find(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public List<T> FindAll(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindIndex(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindIndex(int startIndex, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public T FindLast(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindLastIndex(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        public void ForEach(Action<T> action)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a shallow copy of a range of elements in the source <see cref="T:System.Collections.Generic.List`1" />.</summary><returns>A shallow copy of a range of elements in the source <see cref="T:System.Collections.Generic.List`1" />.</returns><param name="index">The zero-based <see cref="T:System.Collections.Generic.List`1" /> index at which the range starts.</param><param name="count">The number of elements in the range.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />.</exception>
        public List<T> GetRange(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(T item, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(T item, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void InsertRange(int index, IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public int LastIndexOf(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public int LastIndexOf(T item, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public int LastIndexOf(T item, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public int RemoveAll(Predicate<T> match)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.Generic.List`1" />.</summary><param name="index">The zero-based index of the element to remove.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes a range of elements from the <see cref="T:System.Collections.Generic.List`1" />.</summary><param name="index">The zero-based starting index of the range of elements to remove.</param><param name="count">The number of elements to remove.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />.</exception>
        public void RemoveRange(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void Reverse()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reverses the order of the elements in the specified range.</summary><param name="index">The zero-based starting index of the range to reverse.</param><param name="count">The number of elements in the range to reverse.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="count" /> is less than 0. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />. </exception>
        public void Reverse(int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void Sort()
        {
             throw new NotImplementedException();
        }
        
        
        public void Sort(IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public void Sort(int index, int count, IComparer<T> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public void Sort(Comparison<T> comparison)
        {
             throw new NotImplementedException();
        }
        
        
        public T[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public void TrimExcess()
        {
             throw new NotImplementedException();
        }
        
        
        public bool TrueForAll(Predicate<T> match)
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

        IEnumerator IEnumerable.GetEnumerator()
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

        bool IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
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

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
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
