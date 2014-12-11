using System.Collections.Generic;
using System.Collections;

namespace System.Collections.Concurrent
{
    /// <summary>Defines methods to manipulate thread-safe collections intended for producer/consumer usage. This interface provides a unified representation for producer/consumer collections so that higher level abstractions such as <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> can use the collection as the underlying storage mechanism.</summary><typeparam name="T">Specifies the type of elements in the collection.</typeparam>
    public interface IProducerConsumerCollection<T> : IEnumerable<T>, ICollection
    {
        void CopyTo(T[] array, int index);
        
        
        bool TryAdd(T item);
        
        
        bool TryTake(ref T item);
        
        
        T[] ToArray();
        
        
    }
}
