using System.Net.Sockets;

namespace System.Net
{
    public class DnsEndPoint : EndPoint
    {
    
        public string Host
        {
            get { throw new NotImplementedException(); }
        }
    
        public override AddressFamily AddressFamily
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Port
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public DnsEndPoint(string host, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public DnsEndPoint(string host, int port, AddressFamily addressFamily)
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
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
