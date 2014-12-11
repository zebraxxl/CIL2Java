using System.Net;
using System;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
    public class TcpListener
    {
    
        public Socket Server
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool Active
        {
            get { throw new NotImplementedException(); }
        }
    
        public EndPoint LocalEndpoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool ExclusiveAddressUse
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TcpListener(IPEndPoint localEP)
        {
             throw new NotImplementedException();
        }
        
        
        public TcpListener(IPAddress localaddr, int port)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated. Please use TcpListener(IPAddress localaddr, int port) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public TcpListener(int port)
        {
             throw new NotImplementedException();
        }
        
        
        public static TcpListener Create(int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void AllowNatTraversal(bool allowed)
        {
             throw new NotImplementedException();
        }
        
        
        public void Start()
        {
             throw new NotImplementedException();
        }
        
        
        public void Start(int backlog)
        {
             throw new NotImplementedException();
        }
        
        
        public void Stop()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Pending()
        {
             throw new NotImplementedException();
        }
        
        
        public Socket AcceptSocket()
        {
             throw new NotImplementedException();
        }
        
        
        public TcpClient AcceptTcpClient()
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginAcceptSocket(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket EndAcceptSocket(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<Socket> AcceptSocketAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public Task<TcpClient> AcceptTcpClientAsync()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
