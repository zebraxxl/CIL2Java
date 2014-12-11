using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    [ComVisibleAttribute(false)]
    public class ConcurrentBag<T> : IProducerConsumerCollection<T>
    {
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsEmpty
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ConcurrentBag()
        {
             throw new NotImplementedException();
        }
        
        
        public ConcurrentBag(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryTake(ref T result)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryPeek(ref T result)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int index)
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

        T[] IProducerConsumerCollection<T>.ToArray()
        {
            throw new NotImplementedException();
        }

        bool IProducerConsumerCollection<T>.TryAdd(T item)
        {
            throw new NotImplementedException();
        }

        bool IProducerConsumerCollection<T>.TryTake(out T item)
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

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    }
}
