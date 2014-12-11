using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections;
using System;

namespace System.Collections.Generic
{
    [Serializable]
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class Queue<T> : IEnumerable<T>, ICollection
    {
        [Serializable]
        public struct Enumerator : IEnumerator<T>
        {
        
            public T Current
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public void Dispose()
            {
                 throw new NotImplementedException();
            }
            
            
            public bool MoveNext()
            {
                 throw new NotImplementedException();
            }



            T IEnumerator<T>.Current
            {
                get { throw new NotImplementedException(); }
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }

            object IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }
    
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Queue()
        {
             throw new NotImplementedException();
        }
        
        
        public Queue(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public Queue(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public void Enqueue(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public T Dequeue()
        {
             throw new NotImplementedException();
        }
        
        
        public T Peek()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public T[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public void TrimExcess()
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
