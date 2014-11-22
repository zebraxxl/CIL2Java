using System.Runtime.InteropServices;
using System.Collections;

namespace System.Security.Permissions
{
    /// <summary>Represents a collection of <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> objects. This class cannot be inherited. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class KeyContainerPermissionAccessEntryCollection : ICollection
    {
    
        /// <summary>Gets the item at the specified index in the collection.</summary><returns>The <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object at the specified index in the collection.</returns><param name="index">The zero-based index of the element to access.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is greater than or equal to the collection count. </exception><exception cref="T:System.InvalidOperationException"><paramref name="index" /> is negative. </exception>
        public KeyContainerPermissionAccessEntry this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of items in the collection.</summary><returns>The number of <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> objects in the collection.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the collection is synchronized (thread safe).</summary><returns>false in all cases.</returns>
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the collection.</summary><returns>An object that can be used to synchronize access to the collection. </returns>
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Adds a <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object to the collection.</summary><returns>The index at which the new element was inserted.</returns><param name="accessEntry">The <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object to add.</param><exception cref="T:System.ArgumentNullException"><paramref name="accessEntry" /> is null.</exception>
        public int Add(KeyContainerPermissionAccessEntry accessEntry)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the index in the collection of the specified <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object, if it exists in the collection.</summary><returns>The index of the specified <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object in the collection, or –1 if no match is found.</returns><param name="accessEntry">The <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object to locate.</param>
        public int IndexOf(KeyContainerPermissionAccessEntry accessEntry)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object from thecollection.</summary><param name="accessEntry">The <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> object to remove.</param><exception cref="T:System.ArgumentNullException"><paramref name="accessEntry" /> is null.</exception>
        public void Remove(KeyContainerPermissionAccessEntry accessEntry)
        {
             throw new NotImplementedException();
        }
        
        
        public KeyContainerPermissionAccessEntryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the elements of the collection to a compatible one-dimensional array, starting at the specified index of the target array.</summary><param name="array">The one-dimensional <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> array that is the destination of the elements copied from the current collection. </param><param name="index">The index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than the lower bound of <paramref name="array" />. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the collection is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
        public void CopyTo(KeyContainerPermissionAccessEntry[] array, int index)
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
