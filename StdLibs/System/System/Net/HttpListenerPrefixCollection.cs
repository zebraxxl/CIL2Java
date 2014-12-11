using System.Collections.Generic;
using System;

namespace System.Net
{
    public class HttpListenerPrefixCollection : ICollection<String>, IEnumerable<String>
    {
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void CopyTo(Array array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(string[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(string uriPrefix)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(string uriPrefix)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<string> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(string uriPrefix)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }



        void ICollection<string>.Add(string item)
        {
            throw new NotImplementedException();
        }

        void ICollection<string>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<string>.Contains(string item)
        {
            throw new NotImplementedException();
        }

        void ICollection<string>.CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<string>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<string>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<string>.Remove(string item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
