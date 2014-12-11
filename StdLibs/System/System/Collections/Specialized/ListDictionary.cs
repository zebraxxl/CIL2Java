using System.Collections;
using System;

namespace System.Collections.Specialized
{
    [Serializable]
    public class ListDictionary : IDictionary
    {
    
        public object this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public ICollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        public ICollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ListDictionary()
        {
             throw new NotImplementedException();
        }
        
        
        public ListDictionary(IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(object key)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(object key)
        {
             throw new NotImplementedException();
        }



        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Clear()
        {
            throw new NotImplementedException();
        }

        bool IDictionary.Contains(object key)
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        ICollection IDictionary.Keys
        {
            get { throw new NotImplementedException(); }
        }

        void IDictionary.Remove(object key)
        {
            throw new NotImplementedException();
        }

        ICollection IDictionary.Values
        {
            get { throw new NotImplementedException(); }
        }

        object IDictionary.this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
