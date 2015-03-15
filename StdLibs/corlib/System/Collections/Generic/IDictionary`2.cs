
namespace System.Collections.Generic
{
    /// <summary>Represents a generic collection of key/value pairs.</summary><typeparam name="TKey">The type of keys in the dictionary.</typeparam><typeparam name="TValue">The type of values in the dictionary.</typeparam><filterpriority>1</filterpriority>
    public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
    {
        TValue this[TKey key]
        {
            get;
            set;
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys of the <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary><returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing the keys of the object that implements <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
        ICollection<TKey> Keys
        {
            get;
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.Generic.ICollection`1" /> containing the values in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary><returns>An <see cref="T:System.Collections.Generic.ICollection`1" /> containing the values in the object that implements <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
        ICollection<TValue> Values
        {
            get;
        }
    
    
        bool ContainsKey(TKey key);
        
        
        void Add(TKey key, TValue value);
        
        
        bool Remove(TKey key);
        
        
        bool TryGetValue(TKey key, out TValue value);
        
        
    }
}
