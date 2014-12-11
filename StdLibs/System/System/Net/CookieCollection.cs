using System.Collections;
using System.Runtime.Serialization;
using System;

namespace System.Net
{
    [Serializable]
    public class CookieCollection : ICollection
    {
    
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public Cookie this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public Cookie this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
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
    
    
        public CookieCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(Cookie cookie)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(CookieCollection cookies)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Cookie[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
