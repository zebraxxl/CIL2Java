using System;
using System.Net;

namespace System.Net.Sockets
{
    public struct IPPacketInformation
    {
    
        public IPAddress Address
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Interface
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static bool operator ==(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2)
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
