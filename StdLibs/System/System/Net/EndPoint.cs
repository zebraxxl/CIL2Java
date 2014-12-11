using System.Net.Sockets;

namespace System.Net
{
    [Serializable]
    public abstract class EndPoint
    {
        public virtual AddressFamily AddressFamily
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public virtual SocketAddress Serialize()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EndPoint Create(SocketAddress socketAddress)
        {
             throw new NotImplementedException();
        }
        
        
        protected EndPoint()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
