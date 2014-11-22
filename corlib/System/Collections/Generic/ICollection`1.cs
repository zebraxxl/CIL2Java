
namespace System.Collections.Generic
{
    /// <summary>Defines methods to manipulate generic collections.</summary><typeparam name="T">The type of the elements in the collection.</typeparam><filterpriority>1</filterpriority>
    public interface ICollection<T> : IEnumerable<T>
    {
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
        int Count
        {
            get;
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</summary><returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.</returns>
        bool IsReadOnly
        {
            get;
        }
    
    
        void Add(T item);
        
        
        void Clear();
        
        
        bool Contains(T item);
        
        
        void CopyTo(T[] array, int arrayIndex);
        
        
        bool Remove(T item);
        
        
    }
}
