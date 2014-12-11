using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections;
using System;

namespace System.Collections.Generic
{
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    [ComVisibleAttribute(false)]
    public class Stack<T> : IEnumerable<T>, ICollection
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
    
    
        public Stack()
        {
             throw new NotImplementedException();
        }
        
        
        public Stack(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public Stack(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void TrimExcess()
        {
             throw new NotImplementedException();
        }
        
        
        public T Peek()
        {
             throw new NotImplementedException();
        }
        
        
        public T Pop()
        {
             throw new NotImplementedException();
        }
        
        
        public void Push(T item)
        {
             throw new NotImplementedException();
        }
        
        
        public T[] ToArray()
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
