
namespace System.Collections.Generic
{
    /// <summary>Represents a collection of objects that can be individually accessed by index.</summary><typeparam name="T">The type of elements in the list.</typeparam><filterpriority>1</filterpriority>
    public interface IList<T> : ICollection<T>
    {
        /// <summary>Gets or sets the element at the specified index.</summary><returns>The element at the specified index.</returns><param name="index">The zero-based index of the element to get or set.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1" />.</exception><exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.Generic.IList`1" /> is read-only.</exception>
        T this[int index]
        {
            get;
            set;
        }
    
    
        int IndexOf(T item);
        
        
        void Insert(int index, T item);
        
        
        /// <summary>Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.</summary><param name="index">The zero-based index of the item to remove.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.Generic.IList`1" />.</exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.IList`1" /> is read-only.</exception>
        void RemoveAt(int index);
        
        
    }
}
