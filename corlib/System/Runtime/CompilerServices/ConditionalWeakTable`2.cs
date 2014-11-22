using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security;

namespace System.Runtime.CompilerServices
{
    /// <summary>Enables compilers to dynamically attach object fields to managed objects.</summary><typeparam name="TKey">The reference type to which the field is attached. </typeparam><typeparam name="TValue">The field's type. This must be a reference type.</typeparam>
    [ComVisibleAttribute(false)]
    public sealed class ConditionalWeakTable<TKey, TValue>
    {
        public delegate TValue CreateValueCallback(TKey key);
    
    
    
        [SecuritySafeCriticalAttribute()]
        public ConditionalWeakTable()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool TryGetValue(TKey key, ref TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Add(TKey key, TValue value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool Remove(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public TValue GetValue(TKey key, CreateValueCallback createValueCallback)
        {
             throw new NotImplementedException();
        }
        
        
        public TValue GetOrCreateValue(TKey key)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        ~ConditionalWeakTable()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
