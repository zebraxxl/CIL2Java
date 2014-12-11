
namespace System.Collections.Generic
{
    /// <summary>Represents a generic read-only collection of key/value pairs.</summary><typeparam name="TKey">The type of keys in the read-only dictionary. </typeparam><typeparam name="TValue">The type of values in the read-only dictionary. </typeparam>
    public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
    {
        TValue this[TKey key]
        {
            get;
        }
    
        /// <summary>Gets an enumerable collection that contains the keys in the read-only dictionary. </summary><returns>An enumerable collection that contains the keys in the read-only dictionary.</returns>
        IEnumerable<TKey> Keys
        {
            get;
        }
    
        /// <summary>Gets an enumerable collection that contains the values in the read-only dictionary.</summary><returns>An enumerable collection that contains the values in the read-only dictionary.</returns>
        IEnumerable<TValue> Values
        {
            get;
        }
    
    
        bool ContainsKey(TKey key);
        
        
        bool TryGetValue(TKey key, ref TValue value);
        
        
    }
}
