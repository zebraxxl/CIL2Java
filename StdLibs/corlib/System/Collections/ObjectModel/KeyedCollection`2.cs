using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;

namespace System.Collections.ObjectModel
{
    /// <summary>Provides the abstract base class for a collection whose keys are embedded in the values.</summary><typeparam name="TKey">The type of keys in the collection.</typeparam><typeparam name="TItem">The type of items in the collection.</typeparam>
    [Serializable]
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
    {
    
        /// <summary>Gets the generic equality comparer that is used to determine equality of keys in the collection.</summary><returns>The implementation of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface that is used to determine equality of keys in the collection.</returns>
        public IEqualityComparer<TKey> Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
        public TItem this[TKey key]
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the lookup dictionary of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary><returns>The lookup dictionary of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, if it exists; otherwise, null.</returns>
        protected IDictionary<TKey, TItem> Dictionary
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected KeyedCollection()
        {
             throw new NotImplementedException();
        }
        
        
        protected KeyedCollection(IEqualityComparer<TKey> comparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        protected void ChangeItemKey(TItem item, TKey newKey)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void ClearItems()
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract TKey GetKeyForItem(TItem item);
        
        
        protected override void InsertItem(int index, TItem item)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary><param name="index">The index of the element to remove.</param>
        protected override void RemoveItem(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void SetItem(int index, TItem item)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
