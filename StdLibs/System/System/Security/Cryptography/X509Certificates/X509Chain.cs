using System;

namespace System.Security.Cryptography.X509Certificates
{
    public class X509Chain
    {
    
        public IntPtr ChainContext
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509ChainPolicy ChainPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509ChainStatus[] ChainStatus
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509ChainElementCollection ChainElements
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static X509Chain Create()
        {
             throw new NotImplementedException();
        }
        
        
        public X509Chain()
        {
             throw new NotImplementedException();
        }
        
        
        public X509Chain(bool useMachineContext)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Chain(IntPtr chainContext)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Build(X509Certificate2 certificate)
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
