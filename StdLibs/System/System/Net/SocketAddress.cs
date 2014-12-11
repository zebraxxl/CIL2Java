using System.Net.Sockets;

namespace System.Net
{
    public class SocketAddress
    {
    
        public AddressFamily Family
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Size
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte this[int offset]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SocketAddress(AddressFamily family)
        {
             throw new NotImplementedException();
        }
        
        
        public SocketAddress(AddressFamily family, int size)
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
