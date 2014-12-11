using System.Collections;

namespace System.Security.Cryptography.X509Certificates
{
    [Serializable]
    public class X509CertificateCollection : CollectionBase
    {
        public class X509CertificateEnumerator : IEnumerator
        {
        
            public X509Certificate Current
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public X509CertificateEnumerator(X509CertificateCollection mappings)
            {
                 throw new NotImplementedException();
            }
            
            
            public bool MoveNext()
            {
                 throw new NotImplementedException();
            }
            
            
            public void Reset()
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
        }
    
        public X509Certificate this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public X509CertificateCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public X509CertificateCollection(X509CertificateCollection value)
        {
             throw new NotImplementedException();
        }
        
        
        public X509CertificateCollection(X509Certificate[] value)
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(X509Certificate value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(X509Certificate[] value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(X509CertificateCollection value)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(X509Certificate value)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(X509Certificate[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(X509Certificate value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, X509Certificate value)
        {
             throw new NotImplementedException();
        }


        public new X509CertificateEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(X509Certificate value)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
