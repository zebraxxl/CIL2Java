using System.Runtime.InteropServices;
using System;

namespace System.Collections
{
    /// <summary>Provides the abstract base class for a strongly typed collection of key/value pairs.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class DictionaryBase : IDictionary
    {
    
        /// <summary>Gets the list of elements contained in the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><returns>A <see cref="T:System.Collections.Hashtable" /> representing the <see cref="T:System.Collections.DictionaryBase" /> instance itself.</returns>
        protected Hashtable InnerHashtable
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of elements contained in the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><returns>An <see cref="T:System.Collections.IDictionary" /> representing the <see cref="T:System.Collections.DictionaryBase" /> instance itself.</returns>
        protected IDictionary Dictionary
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.DictionaryBase" /> instance.</returns><filterpriority>2</filterpriority>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Copies the <see cref="T:System.Collections.DictionaryBase" /> elements to a one-dimensional <see cref="T:System.Array" /> at the specified index.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from the <see cref="T:System.Collections.DictionaryBase" /> instance. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.DictionaryBase" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.DictionaryBase" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the element with the specified key and value in the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><returns>An <see cref="T:System.Object" /> containing the element with the specified key and value.</returns><param name="key">The key of the element to get. </param><param name="currentValue">The current value of the element associated with <paramref name="key" />. </param>
        protected virtual object OnGet(object key, object currentValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes before setting a value in the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><param name="key">The key of the element to locate. </param><param name="oldValue">The old value of the element associated with <paramref name="key" />. </param><param name="newValue">The new value of the element associated with <paramref name="key" />. </param>
        protected virtual void OnSet(object key, object oldValue, object newValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes before inserting a new element into the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><param name="key">The key of the element to insert. </param><param name="value">The value of the element to insert. </param>
        protected virtual void OnInsert(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnClear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes before removing an element from the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><param name="key">The key of the element to remove. </param><param name="value">The value of the element to remove. </param>
        protected virtual void OnRemove(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes when validating the element with the specified key and value.</summary><param name="key">The key of the element to validate. </param><param name="value">The value of the element to validate. </param>
        protected virtual void OnValidate(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes after setting a value in the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><param name="key">The key of the element to locate. </param><param name="oldValue">The old value of the element associated with <paramref name="key" />. </param><param name="newValue">The new value of the element associated with <paramref name="key" />. </param>
        protected virtual void OnSetComplete(object key, object oldValue, object newValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes after inserting a new element into the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><param name="key">The key of the element to insert. </param><param name="value">The value of the element to insert. </param>
        protected virtual void OnInsertComplete(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnClearComplete()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs additional custom processes after removing an element from the <see cref="T:System.Collections.DictionaryBase" /> instance.</summary><param name="key">The key of the element to remove. </param><param name="value">The value of the element to remove. </param>
        protected virtual void OnRemoveComplete(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected DictionaryBase()
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
