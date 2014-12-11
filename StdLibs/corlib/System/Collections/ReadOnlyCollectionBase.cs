using System.Runtime.InteropServices;

namespace System.Collections
{
    /// <summary>Provides the abstract base class for a strongly typed non-generic read-only collection.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class ReadOnlyCollectionBase : ICollection
    {
    
        /// <summary>Gets the list of elements contained in the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</summary><returns>An <see cref="T:System.Collections.ArrayList" /> representing the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance itself.</returns>
        protected ArrayList InnerList
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.Retrieving the value of this property is an O(1) operation.</returns><filterpriority>2</filterpriority>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public virtual IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        protected ReadOnlyCollectionBase()
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
