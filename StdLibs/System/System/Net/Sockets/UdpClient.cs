using System;
using System.Runtime.CompilerServices;
using System.Net;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
    public class UdpClient : IDisposable
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
    
        public short Ttl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool DontFragment
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool MulticastLoopback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool EnableBroadcast
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool ExclusiveAddressUse
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public UdpClient()
        {
             throw new NotImplementedException();
        }
        
        
        public UdpClient(AddressFamily family)
        {
             throw new NotImplementedException();
        }
        
        
        public UdpClient(int port)
        {
             throw new NotImplementedException();
        }
        
        
        public UdpClient(int port, AddressFamily family)
        {
             throw new NotImplementedException();
        }
        
        
        public UdpClient(IPEndPoint localEP)
        {
             throw new NotImplementedException();
        }
        
        
        public UdpClient(string hostname, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void AllowNatTraversal(bool allowed)
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
        
        
        public void Connect(string hostname, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPAddress addr, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPEndPoint endPoint)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] dgram, int bytes, string hostname, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] dgram, int bytes)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndSend(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] Receive(ref IPEndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public void JoinMulticastGroup(IPAddress multicastAddr)
        {
             throw new NotImplementedException();
        }
        
        
        public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr)
        {
             throw new NotImplementedException();
        }
        
        
        public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive)
        {
             throw new NotImplementedException();
        }
        
        
        public void DropMulticastGroup(IPAddress multicastAddr)
        {
             throw new NotImplementedException();
        }
        
        
        public void DropMulticastGroup(IPAddress multicastAddr, int ifindex)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<int> SendAsync(byte[] datagram, int bytes)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<UdpReceiveResult> ReceiveAsync()
        {
             throw new NotImplementedException();
        }



        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
