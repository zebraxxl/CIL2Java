using System.Collections;

namespace System.Collections.Specialized
{
    [Serializable]
    public class StringCollection : IList
    {
    
        public string this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsReadOnly
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
    
    
        public int Add(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(string[] value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(string[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public StringEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public StringCollection()
        {
             throw new NotImplementedException();
        }



        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        int IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        bool IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        object IList.this[int index]
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
