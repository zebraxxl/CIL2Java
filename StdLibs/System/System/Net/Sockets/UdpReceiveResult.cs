using System;
using System.Net;

namespace System.Net.Sockets
{
    public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
    {
    
        public byte[] Buffer
        {
            get { throw new NotImplementedException(); }
        }
    
        public IPEndPoint RemoteEndPoint
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(UdpReceiveResult other)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(UdpReceiveResult left, UdpReceiveResult right)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(UdpReceiveResult left, UdpReceiveResult right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
