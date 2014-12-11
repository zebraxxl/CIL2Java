using System.Collections;
using System;

namespace System.Text.RegularExpressions
{
    [Serializable]
    public class CaptureCollection : ICollection
    {
    
        public object SyncRoot
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
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public Capture this[int i]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void CopyTo(Array array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
