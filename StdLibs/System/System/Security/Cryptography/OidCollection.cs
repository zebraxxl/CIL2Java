using System.Collections;

namespace System.Security.Cryptography
{
    public sealed class OidCollection : ICollection
    {
    
        public Oid this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public Oid this[string oid]
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
    
    
        public OidCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(Oid oid)
        {
             throw new NotImplementedException();
        }
        
        
        public OidEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Oid[] array, int index)
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
