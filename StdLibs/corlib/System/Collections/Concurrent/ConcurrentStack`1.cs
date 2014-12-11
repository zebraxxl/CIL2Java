using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    /// <summary>Represents a thread-safe last in-first out (LIFO) collection.</summary><typeparam name="T">The type of the elements contained in the stack.</typeparam>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class ConcurrentStack<T> : IProducerConsumerCollection<T>
    {
    
        /// <summary>Gets a value that indicates whether the <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> is empty.</summary><returns>true if the <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> is empty; otherwise, false.</returns>
        public bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ConcurrentStack()
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentStack(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public void Push(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void PushRange(T[] items)
        {
             throw new NotImplementedException();
        }
        
        
        public void PushRange(T[] items, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryPeek(ref T result)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryPop(ref T result)
        {
             throw new NotImplementedException();
        }
        
        
        public int TryPopRange(T[] items)
        {
             throw new NotImplementedException();
        }
        
        
        public int TryPopRange(T[] items, int startIndex, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public T[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<T> GetEnumerator()
        {
             throw new NotImplementedException();
        }



        void IProducerConsumerCollection<T>.CopyTo(T[] array, int index)
        {
            throw new NotImplementedException();
        }

        bool IProducerConsumerCollection<T>.TryAdd(T item)
        {
            throw new NotImplementedException();
        }

        bool IProducerConsumerCollection<T>.TryTake(ref T item)
        {
            throw new NotImplementedException();
        }

        T[] IProducerConsumerCollection<T>.ToArray()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
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
    }
}
