using System;

namespace System.Security.Cryptography.X509Certificates
{
    public sealed class X509Store
    {
    
        public IntPtr StoreHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        public StoreLocation Location
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509Certificate2Collection Certificates
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509Store()
        {
             throw new NotImplementedException();
        }
        
        
        public X509Store(string storeName)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Store(StoreName storeName)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Store(StoreLocation storeLocation)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Store(StoreName storeName, StoreLocation storeLocation)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Store(string storeName, StoreLocation storeLocation)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Store(IntPtr storeHandle)
        {
             throw new NotImplementedException();
        }
        
        
        public void Open(OpenFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(X509Certificate2Collection certificates)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveRange(X509Certificate2Collection certificates)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
