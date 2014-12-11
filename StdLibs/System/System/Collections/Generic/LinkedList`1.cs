using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections;
using System.Runtime.Serialization;
using System;

namespace System.Collections.Generic
{
    [Serializable]
    [ComVisibleAttribute(false)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class LinkedList<T> : ICollection<T>, ICollection, ISerializable, IDeserializationCallback
    {
        [Serializable]
        public struct Enumerator : IEnumerator<T>, ISerializable, IDeserializationCallback
        {
        
            public T Current
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public bool MoveNext()
            {
                 throw new NotImplementedException();
            }
            
            
            public void Dispose()
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

            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            void IDeserializationCallback.OnDeserialization(object sender)
            {
                throw new NotImplementedException();
            }
        }
    
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public LinkedListNode<T> First
        {
            get { throw new NotImplementedException(); }
        }
    
        public LinkedListNode<T> Last
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public LinkedList()
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedList(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        protected LinkedList(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedListNode<T> AddFirst(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddFirst(LinkedListNode<T> node)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedListNode<T> AddLast(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddLast(LinkedListNode<T> node)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(T[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedListNode<T> Find(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedListNode<T> FindLast(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(T value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(LinkedListNode<T> node)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveFirst()
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveLast()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }



        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Contains(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<T>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<T>.Remove(T item)
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
