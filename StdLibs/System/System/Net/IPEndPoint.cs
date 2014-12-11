using System.Net.Sockets;

namespace System.Net
{
    [Serializable]
    public class IPEndPoint : EndPoint
    {
        public const int MinPort = 0;
        public const int MaxPort = 65535;
    
        public override AddressFamily AddressFamily
        {
            get { throw new NotImplementedException(); }
        }
    
        public IPAddress Address
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Port
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public IPEndPoint(long address, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public IPEndPoint(IPAddress address, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public override SocketAddress Serialize()
        {
             throw new NotImplementedException();
        }
        
        
        public override EndPoint Create(SocketAddress socketAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object comparand)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
