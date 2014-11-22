using System.Runtime.InteropServices;

namespace System.Collections
{
    /// <summary>Provides the abstract base class for a strongly typed collection.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class CollectionBase : IList
    {
    
        /// <summary>Gets an <see cref="T:System.Collections.ArrayList" /> containing the list of elements in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><returns>An <see cref="T:System.Collections.ArrayList" /> representing the <see cref="T:System.Collections.CollectionBase" /> instance itself.Retrieving the value of this property is an O(1) operation.</returns>
        protected ArrayList InnerList
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.IList" /> containing the list of elements in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><returns>An <see cref="T:System.Collections.IList" /> representing the <see cref="T:System.Collections.CollectionBase" /> instance itself.</returns>
        protected IList List
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of elements that the <see cref="T:System.Collections.CollectionBase" /> can contain.</summary><returns>The number of elements that the <see cref="T:System.Collections.CollectionBase" /> can contain.</returns><exception cref="T:System.ArgumentOutOfRangeException"><see cref="P:System.Collections.CollectionBase.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.CollectionBase.Count" />.</exception><exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception><filterpriority>2</filterpriority>
        [ComVisibleAttribute(false)]
        public int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.CollectionBase" /> instance. This property cannot be overridden.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.CollectionBase" /> instance.Retrieving the value of this property is an O(1) operation.</returns><filterpriority>2</filterpriority>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected CollectionBase()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.CollectionBase" /> class with the specified capacity.</summary><param name="capacity">The number of elements that the new list can initially store.</param>
        protected CollectionBase(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.CollectionBase" /> instance. This method is not overridable.</summary><param name="index">The zero-based index of the element to remove.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.CollectionBase.Count" />.</exception><filterpriority>2</filterpriority>
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes before setting a value in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><param name="index">The zero-based index at which <paramref name="oldValue" /> can be found.</param><param name="oldValue">The value to replace with <paramref name="newValue" />.</param><param name="newValue">The new value of the element at <paramref name="index" />.</param>
        protected virtual void OnSet(int index, object oldValue, object newValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes before inserting a new element into the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><param name="index">The zero-based index at which to insert <paramref name="value" />.</param><param name="value">The new value of the element at <paramref name="index" />.</param>
        protected virtual void OnInsert(int index, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnClear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes when removing an element from the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><param name="index">The zero-based index at which <paramref name="value" /> can be found.</param><param name="value">The value of the element to remove from <paramref name="index" />.</param>
        protected virtual void OnRemove(int index, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes when validating a value.</summary><param name="value">The object to validate.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null.</exception>
        protected virtual void OnValidate(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes after setting a value in the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><param name="index">The zero-based index at which <paramref name="oldValue" /> can be found.</param><param name="oldValue">The value to replace with <paramref name="newValue" />.</param><param name="newValue">The new value of the element at <paramref name="index" />.</param>
        protected virtual void OnSetComplete(int index, object oldValue, object newValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes after inserting a new element into the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><param name="index">The zero-based index at which to insert <paramref name="value" />.</param><param name="value">The new value of the element at <paramref name="index" />.</param>
        protected virtual void OnInsertComplete(int index, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnClearComplete()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes after removing an element from the <see cref="T:System.Collections.CollectionBase" /> instance.</summary><param name="index">The zero-based index at which <paramref name="value" /> can be found.</param><param name="value">The value of the element to remove from <paramref name="index" />.</param>
        protected virtual void OnRemoveComplete(int index, object value)
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
