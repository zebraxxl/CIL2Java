using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509ExtensionCollection : ICollection
    {
    
        public X509Extension this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509Extension this[string oid]
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
    
    
        public X509ExtensionCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(X509Extension extension)
        {
             throw new NotImplementedException();
        }
        
        
        public X509ExtensionEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(X509Extension[] array, int index)
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
