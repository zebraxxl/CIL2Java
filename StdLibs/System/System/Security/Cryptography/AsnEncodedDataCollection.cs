using System.Collections;

namespace System.Security.Cryptography
{
    public sealed class AsnEncodedDataCollection : ICollection
    {
    
        public AsnEncodedData this[int index]
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
    
    
        public AsnEncodedDataCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public AsnEncodedDataCollection(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
        public AsnEncodedDataEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(AsnEncodedData[] array, int index)
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
