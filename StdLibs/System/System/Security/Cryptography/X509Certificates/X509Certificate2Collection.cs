
namespace System.Security.Cryptography.X509Certificates
{
    public class X509Certificate2Collection : X509CertificateCollection
    {
    
        public new X509Certificate2 this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public X509Certificate2Collection()
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2Collection(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2Collection(X509Certificate2Collection certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2Collection(X509Certificate2[] certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(X509Certificate2[] certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(X509Certificate2Collection certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }


        public new X509Certificate2Enumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveRange(X509Certificate2[] certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveRange(X509Certificate2Collection certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public void Import(byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        public void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public void Import(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] Export(X509ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] Export(X509ContentType contentType, string password)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
