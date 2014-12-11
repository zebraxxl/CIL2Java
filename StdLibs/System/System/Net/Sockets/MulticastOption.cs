using System.Net;

namespace System.Net.Sockets
{
    public class MulticastOption
    {
    
        public IPAddress Group
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public IPAddress LocalAddress
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int InterfaceIndex
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public MulticastOption(IPAddress group, IPAddress mcint)
        {
             throw new NotImplementedException();
        }
        
        
        public MulticastOption(IPAddress group, int interfaceIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public MulticastOption(IPAddress group)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
