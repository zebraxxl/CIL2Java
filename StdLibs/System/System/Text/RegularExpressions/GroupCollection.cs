using System.Collections;
using System;

namespace System.Text.RegularExpressions
{
    [Serializable]
    public class GroupCollection : ICollection
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
    
        public Group this[int groupnum]
        {
            get { throw new NotImplementedException(); }
        }
    
        public Group this[string groupname]
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
