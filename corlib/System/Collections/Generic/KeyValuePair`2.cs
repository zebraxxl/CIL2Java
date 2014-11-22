using System;

namespace System.Collections.Generic
{
    /// <summary>Defines a key/value pair that can be set or retrieved.</summary><typeparam name="TKey">The type of the key.</typeparam><typeparam name="TValue">The type of the value.</typeparam><filterpriority>1</filterpriority>
    [Serializable]
    public struct KeyValuePair<TKey, TValue>
    {
    
        /// <summary>Gets the key in the key/value pair.</summary><returns>A <paramref name="TKey" /> that is the key of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />. </returns>
        public TKey Key
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value in the key/value pair.</summary><returns>A <paramref name="TValue" /> that is the value of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />. </returns>
        public TValue Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public KeyValuePair(TKey key, TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
