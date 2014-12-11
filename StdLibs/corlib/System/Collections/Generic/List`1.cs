using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.Generic
{
    /// <summary>
    /// Represents a strongly typed list of objects that can be accessed by index. Provides methods to search,
    /// sort, and manipulate lists.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <filterpriority>1</filterpriority>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class List<T> : IList<T>, IList, IReadOnlyList<T>
    {
        [Serializable]
        public struct Enumerator : IEnumerator<T>
        {
            private readonly List<T> list;
            private int next;
            private readonly int version;
            private T current;

            internal Enumerator(List<T> list)
                : this()
            {
                this.list = list;
                this.version = list.version;
            }
        
            public T Current
            {
                get { return current; }
            }        
        
            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (next < 0)
                    return false;

                if ((next < list.size) && (version == list.version))
                {
                    current = list.items[next++];
                    return true;
                }

                if (version != list.version)
                    throw new InvalidOperationException(Local.GetText("Collection was modified; enumeration operation may not execute."));

                next = -1;
                return false;
            }

            void IEnumerator.Reset()
            {
                if (version != list.version)
                    throw new InvalidOperationException(Local.GetText("Collection was modified; enumeration operation may not execute."));

                next = 0;
            }

            object IEnumerator.Current
            {
                get
                {
                    if (version != list.version)
                        throw new InvalidOperationException(Local.GetText("Collection was modified; enumeration operation may not execute."));

                    if (next <= 0)
                        throw new InvalidOperationException();

                    return current;
                }
            }
        }

        private static readonly T[] emptyArray = new T[0];

        private T[] items;
        private int size;
        private int version;
        private object syncRoot;

        private void checkSize(int minSize)
        {
            if (items.Length < minSize)
            {
                int newSize = items.Length == 0 ? 4 : items.Length * 2;
                newSize = Math.Max(newSize, minSize);
                Capacity = newSize;
            }
        }
    
        /// <summary>
        /// Gets or sets the total number of elements the internal data structure can hold without resizing.
        /// </summary>
        /// <returns>
        /// The number of elements that the <see cref="T:System.Collections.Generic.List`1" /> can contain 
        /// before resizing is required.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <see cref="P:System.Collections.Generic.List`1.Capacity" /> is set to a value that is less
        /// than <see cref="P:System.Collections.Generic.List`1.Count" />. 
        /// </exception>
        /// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
        public int Capacity
        {
            get { return items.Length; }
            set
            {
                if (value < size)
                    throw new ArgumentOutOfRangeException("value");

                Array.Resize(ref items, value);
            }
        }
    
        /// <summary>
        /// Gets the number of elements actually contained in the <see cref="T:System.Collections.Generic.List`1" />.
        /// </summary>
        /// <returns>
        /// The number of elements actually contained in the <see cref="T:System.Collections.Generic.List`1" />.
        /// </returns>
        public int Count
        {
            get { return size; }
        }
    
        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <returns>The element at the specified index.</returns>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater 
        /// than <see cref="P:System.Collections.Generic.List`1.Count" />. 
        /// </exception>
        public T this[int index]
        {
            get
            {
                if ((index < 0) || (index >= size))
                    throw new ArgumentOutOfRangeException("index");
                return items[index];
            }

            set
            {
                if ((index < 0) || (index >= size))
                    throw new ArgumentOutOfRangeException("index");
                items[index] = value;
                version++;
            }
        }
    
        public List()
        {
            items = emptyArray;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Collections.Generic.List`1" /> 
        /// class that is empty and has the specified initial capacity.
        /// </summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than 0. </exception>
        public List(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("capacity");
            items = new T[capacity];
        }
        
        public List(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            ICollection<T> c = collection as ICollection<T>;

            if (c != null)
            {
                size = c.Count;

                if (size > 0)
                {
                    items = new T[size];
                    c.CopyTo(items, 0);
                }
                else
                    items = emptyArray;
            }
            else
            {
                items = emptyArray;

                foreach (T val in collection)
                {
                    this.Add(val);
                }
            }
        }
        
        public void Add(T item)
        {
            if (size == items.Length)
                checkSize(size + 1);

            items[size++] = item;
            version++;
        }        
        
        public void AddRange(IEnumerable<T> collection)
        {
            InsertRange(size, collection);
        }        
        
        public ReadOnlyCollection<T> AsReadOnly()
        {
            return new ReadOnlyCollection<T>(this);
        }        
        
        public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
        {
            return Array.BinarySearch(items, index, count, item, comparer);
        }

        public int BinarySearch(T item)
        {
            return Array.BinarySearch(items, item);
        }        
        
        public int BinarySearch(T item, IComparer<T> comparer)
        {
            return Array.BinarySearch(items, item, comparer);
        }        
        
        public void Clear()
        {
            if (size > 0)
            {
                Array.Clear(items, 0, size);
                size = 0;
            }
            version++;
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                for (int i = 0; i < size; i++)
                    if (items[i] == null)
                        return true;
                return false;
            }

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < size; i++)
            {
                if (comparer.Equals(this.items[i], item))
                    return true;
            }
            return false;
        }
        
        public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
        {
            if (converter == null)
                throw new ArgumentNullException("converter");

            List<TOutput> result = new List<TOutput>(size);
            for (int i = 0; i < size; i++)
                result.items[i] = converter(items[i]);
            result.size = size;
            return result;
        }
        
        public void CopyTo(T[] array)
        {
            CopyTo(array, 0);
        }        
        
        public void CopyTo(int index, T[] array, int arrayIndex, int count)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (size - index < count)
                throw new ArgumentException(Local.GetText("index and count exceed length of list"));

            Array.Copy(items, index, array, arrayIndex, count);
        }        
        
        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(items, 0, array, arrayIndex, size);
        }
        
        public bool Exists(Predicate<T> match)
        {
            return FindIndex(match) != -1;
        }        
        
        public T Find(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException("match");
            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                    return items[i];
            }

            return default(T);
        }        
        
        public List<T> FindAll(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException("match");

            List<T> result = new List<T>();
            for (int i = 0; i < size; i++)
            {
                if (match(items[i]))
                    result.Add(items[i]);
            }

            return result;
        }        
        
        public int FindIndex(Predicate<T> match)
        {
            return FindIndex(0, size, match);
        }        
        
        public int FindIndex(int startIndex, Predicate<T> match)
        {
            return FindIndex(startIndex, size - startIndex, match);
        }        
        
        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            if (startIndex > size)
                throw new ArgumentOutOfRangeException("startIndex");
            if ((count < 0) || (startIndex > size - count))
                throw new ArgumentOutOfRangeException("count");
            if (match == null)
                throw new ArgumentNullException("match");

            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
                if (match(items[i]))
                    return i;
            return -1;
        }        
        
        public T FindLast(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException("match");

            for (int i = size - 1; i >= 0; i++)
                if (match(items[i]))
                    return items[i];

            return default(T);
        }        
        
        public int FindLastIndex(Predicate<T> match)
        {
            return FindLastIndex(size - 1, size, match);
        }        
        
        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
            return FindLastIndex(startIndex, startIndex + 1, match);
        }        
        
        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException("match");
            if (size == 0)
            {
                if (startIndex != -1)
                    throw new ArgumentOutOfRangeException("startIndex");
            }
            else
            {
                if (startIndex >= size)
                    throw new ArgumentOutOfRangeException("startIndex");
            }

            if ((count < 0) || (startIndex - count + 1 < 0))
                throw new ArgumentOutOfRangeException("count");

            int lastIndex = startIndex - count;

            for (int i = startIndex; i > lastIndex; i--)
                if (match(items[i]))
                    return i;

            return -1;
        }        
        
        public void ForEach(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            int lastVersion = version;

            for (int i = 0; ((i < size) && (lastVersion == version)); i++)
                action(items[i]);

            if (lastVersion != version)
                throw new InvalidOperationException(Local.GetText("Collection was modified; enumeration operation may not execute."));
        }        
        
        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }        
        
        /// <summary>
        /// Creates a shallow copy of a range of elements in the source <see cref="T:System.Collections.Generic.List`1" />.
        /// </summary>
        /// <returns>A shallow copy of a range of elements in the source <see cref="T:System.Collections.Generic.List`1" />.</returns>
        /// <param name="index">The zero-based <see cref="T:System.Collections.Generic.List`1" /> index at which the range starts.</param>
        /// <param name="count">The number of elements in the range.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />.</exception>
        public List<T> GetRange(int index, int count)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (size - index < count)
                throw new ArgumentException(Local.GetText("index and count exceed length of list"));

            List<T> result = new List<T>(count);
            Array.Copy(items, index, result.items, 0, count);
            result.size = count;
            return result;
        }        
        
        public int IndexOf(T item)
        {
            return Array.IndexOf(items, item, 0, size);
        }        
        
        public int IndexOf(T item, int index)
        {
            if (index > size)
                throw new ArgumentOutOfRangeException("index");
            return Array.IndexOf(items, item, index, size - index);
        }        
        
        public int IndexOf(T item, int index, int count)
        {
            if (index > size)
                throw new ArgumentOutOfRangeException("index");
            if ((count < 0) || (index > size - count))
                throw new ArgumentOutOfRangeException("count");

            return Array.IndexOf(items, item, index, count);
        }        
        
        public void Insert(int index, T item)
        {
            if (index > size)
                throw new ArgumentOutOfRangeException("index");
            
            if (size == items.Length)
                checkSize(size + 1);

            if (index < size)
                Array.Copy(items, index, items, index + 1, size - index);

            items[index] = item;
            size++;
            version++;
        }        
        
        public void InsertRange(int index, IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");
            if (index > size)
                throw new ArgumentOutOfRangeException("index");

            ICollection<T> c = collection as ICollection<T>;
            if (c != null)
            {
                int count = c.Count;
                if (count > 0)
                {
                    checkSize(size + count);
                    if (index < size)
                        Array.Copy(items, index, items, index + count, size - index);

                    if (this == c)
                    {
                        Array.Copy(items, 0, items, index, index);
                        Array.Copy(items, index + count, items, index * 2, size - index);
                    }
                    else
                    {
                        T[] arr = new T[count];
                        c.CopyTo(arr, 0);
                        arr.CopyTo(items, index);
                    }
                    size += count;
                }
            }
            else
            {
                foreach (T val in collection)
                    Insert(index++, val);
            }
            version++;
        }        
        
        public int LastIndexOf(T item)
        {
            if (size == 0)
                return -1;
            return LastIndexOf(item, 0, size);
        }        
        
        public int LastIndexOf(T item, int index)
        {
            if (index >= size)
                throw new ArgumentOutOfRangeException("index");
            return LastIndexOf(item, index, index + 1);
        }        
        
        public int LastIndexOf(T item, int index, int count)
        {
            if ((size != 0) && (index < 0))
                throw new ArgumentOutOfRangeException("index");
            if ((size != 0) && (count < 0))
                throw new ArgumentOutOfRangeException("count");
            if (size == 0)
                return -1;
            if (index >= size)
                throw new ArgumentOutOfRangeException("index");
            if (count > index + 1)
                throw new ArgumentOutOfRangeException("count");
            return Array.LastIndexOf(items, item, index, count);
        }        
        
        public bool Remove(T item)
        {
            int i = IndexOf(item);
            if (i >= 0)
            {
                RemoveAt(i);
                return true;
            }
            return false;
        }        
        
        public int RemoveAll(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException("match");

            int index = 0;
            while ((index < size) && (!match(items[index])))
                index++;

            if (index >= size)
                return 0;

            int i = index + 1;
            while (i < size)
            {
                while ((i < size) && (match(items[i])))
                    i++;
                if (i < size)
                    items[index++] = items[i];
            }

            Array.Clear(items, index, size - index);

            int result = size - index;
            size = index;
            version++;
            return result;
        }        
        
        /// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.Generic.List`1" />.</summary><param name="index">The zero-based index of the element to remove.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
        public void RemoveAt(int index)
        {
            if (index >= size)
                throw new ArgumentOutOfRangeException("index");
            size--;
            if (index < size)
                Array.Copy(items, index + 1, items, index, size - index);
            items[size] = default(T);
            version++;
        }        
        
        /// <summary>Removes a range of elements from the <see cref="T:System.Collections.Generic.List`1" />.</summary><param name="index">The zero-based starting index of the range of elements to remove.</param><param name="count">The number of elements to remove.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="count" /> is less than 0.</exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />.</exception>
        public void RemoveRange(int index, int count)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (size - index < count)
                throw new ArgumentException();
            if (count > 0)
            {
                size -= count;
                if (index < size)
                    Array.Copy(items, index + count, items, index, size - index);

                Array.Clear(items, size, count);
                version++;
            }
        }        
        
        public void Reverse()
        {
            Reverse(0, size);
        }        
        
        /// <summary>Reverses the order of the elements in the specified range.</summary><param name="index">The zero-based starting index of the range to reverse.</param><param name="count">The number of elements in the range to reverse.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0.-or-<paramref name="count" /> is less than 0. </exception><exception cref="T:System.ArgumentException"><paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.Generic.List`1" />. </exception>
        public void Reverse(int index, int count)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (size - index < count)
                throw new ArgumentException();

            Array.Reverse(items, index, count);
        }        
        
        public void Sort()
        {
            Sort(0, size, null);
        }        
        
        public void Sort(IComparer<T> comparer)
        {
            Sort(0, size, comparer);
        }        
        
        public void Sort(int index, int count, IComparer<T> comparer)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (size - index < count)
                throw new ArgumentException();
            Array.Sort(items, index, count, comparer);
        }        
        
        public void Sort(Comparison<T> comparison)
        {
            if (comparison == null)
                throw new ArgumentNullException("comparison");

            if (size > 0)
                Array.Sort(items, comparison);
            
        }        
        
        public T[] ToArray()
        {
            T[] result = new T[size];
            Array.Copy(items, 0, result, 0, size);
            return result;
        }        
        
        public void TrimExcess()
        {
            Capacity = size;
        }
        
        public bool TrueForAll(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException("match");
            for (int i = 0; i < size; i++)
                if (!match(items[i]))
                    return false;
            return true;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new List<T>.Enumerator(this);
        }

        void ICollection.CopyTo(Array array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if ((array.Rank > 1) || (array.GetLowerBound(0) != 0))
                throw new ArgumentException(Local.GetText("Array must be zero based and single dimentional"), "array");

            try
            {
                Array.Copy(items, 0, array, arrayIndex, size);
            }
            catch (ArrayTypeMismatchException)
            {
                throw new ArgumentException();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new List<T>.Enumerator(this);
        }

        int IList.Add(object item)
        {
            try
            {
                this.Add((T)item);
                return Count - 1;
            }
            catch (NullReferenceException) { }
            catch (InvalidCastException) { }
            throw new ArgumentException();
        }

        private static bool IsCompatibleObject(object value)
        {
            return value is T || (value == null && default(T) == null);
        }

        bool IList.Contains(object item)
        {
            return List<T>.IsCompatibleObject(item) && this.Contains((T)((object)item));
        }

        int IList.IndexOf(object item)
        {
            if (List<T>.IsCompatibleObject(item))
            {
                return this.IndexOf((T)((object)item));
            }
            return -1;
        }

        void IList.Insert(int index, object item)
        {
            if (index > size)
                throw new ArgumentOutOfRangeException("index");

            try
            {
                Insert(index, (T)item);
                return;
            }
            catch (NullReferenceException) { }
            catch (InvalidCastException) { }
            throw new ArgumentException("item");
        }

        void IList.Remove(object item)
        {
            if (List<T>.IsCompatibleObject(item))
            {
                this.Remove((T)((object)item));
            }
        }

        bool ICollection<T>.IsReadOnly { get { return false; } }

        bool IList.IsFixedSize { get { return false; } }
        bool IList.IsReadOnly { get { return false; } }

        object IList.this[int index]
        {
            get { return this[index]; }
            set
            {
                try
                {
                    this[index] = (T)value;
                    return;
                }
                catch (NullReferenceException) { }
                catch (InvalidCastException) { }
                throw new ArgumentException("value");
            }
        }

        bool ICollection.IsSynchronized { get { return false; } }

        object ICollection.SyncRoot
        {
            get
            {
                if (this.syncRoot == null)
                {
                    Interlocked.CompareExchange<object>(ref this.syncRoot, new object(), null);
                }
                return this.syncRoot;
            }
        }

    }
}
