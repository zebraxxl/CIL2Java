using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Concurrent
{
    [DebuggerDisplayAttribute("Count = {Count}, Type = {m_collection}")]
    [ComVisibleAttribute(false)]
    public class BlockingCollection<T> : IEnumerable<T>, ICollection, IDisposable
    {
    
        public int BoundedCapacity
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsAddingCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public BlockingCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public BlockingCollection(int boundedCapacity)
        {
             throw new NotImplementedException();
        }
        
        
        public BlockingCollection(IProducerConsumerCollection<T> collection, int boundedCapacity)
        {
             throw new NotImplementedException();
        }
        
        
        public BlockingCollection(IProducerConsumerCollection<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(T item, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryAdd(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryAdd(T item, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryAdd(T item, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryAdd(T item, int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public T Take()
        {
             throw new NotImplementedException();
        }
        
        
        public T Take(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryTake(ref T item)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryTake(ref T item, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryTake(ref T item, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryTake(ref T item, int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static int AddToAny(BlockingCollection<T>[] collections, T item)
        {
             throw new NotImplementedException();
        }
        
        
        public static int AddToAny(BlockingCollection<T>[] collections, T item, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TakeFromAny(BlockingCollection<T>[] collections, ref T item)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TakeFromAny(BlockingCollection<T>[] collections, ref T item, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, ref T item)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, ref T item, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, ref T item, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static int TryTakeFromAny(BlockingCollection<T>[] collections, ref T item, int millisecondsTimeout, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void CompleteAdding()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public T[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<T> GetConsumingEnumerable()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<T> GetConsumingEnumerable(CancellationToken cancellationToken)
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
