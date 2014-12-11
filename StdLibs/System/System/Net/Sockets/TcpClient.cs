using System;
using System.Net;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
    public class TcpClient : IDisposable
    {
    
        public Socket Client
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected bool Active
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Available
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool Connected
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool ExclusiveAddressUse
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ReceiveBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int SendBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ReceiveTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int SendTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public LingerOption LingerState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool NoDelay
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TcpClient(IPEndPoint localEP)
        {
             throw new NotImplementedException();
        }
        
        
        public TcpClient()
        {
             throw new NotImplementedException();
        }
        
        
        public TcpClient(AddressFamily family)
        {
             throw new NotImplementedException();
        }
        
        
        public TcpClient(string hostname, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(string hostname, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPAddress address, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPEndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPAddress[] ipAddresses, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public void EndConnect(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ConnectAsync(IPAddress address, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ConnectAsync(string host, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public Task ConnectAsync(IPAddress[] addresses, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkStream GetStream()
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        ~TcpClient()
        {
             throw new NotImplementedException();
        }



        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
