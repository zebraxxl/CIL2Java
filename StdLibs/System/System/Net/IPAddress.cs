using System;
using System.Net.Sockets;

namespace System.Net
{
    [Serializable]
    public class IPAddress
    {
        public static readonly IPAddress Any;
        public static readonly IPAddress Loopback;
        public static readonly IPAddress Broadcast;
        public static readonly IPAddress None;
        public static readonly IPAddress IPv6Any;
        public static readonly IPAddress IPv6Loopback;
        public static readonly IPAddress IPv6None;
    
        [ObsoleteAttribute("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. http://go.microsoft.com/fwlink/?linkid=14202")]
        public long Address
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public AddressFamily AddressFamily
        {
            get { throw new NotImplementedException(); }
        }
    
        public long ScopeId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsIPv6Multicast
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsIPv6LinkLocal
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsIPv6SiteLocal
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsIPv6Teredo
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsIPv4MappedToIPv6
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public IPAddress(long newAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public IPAddress(byte[] address, long scopeid)
        {
             throw new NotImplementedException();
        }
        
        
        public IPAddress(byte[] address)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string ipString, ref IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public static IPAddress Parse(string ipString)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetAddressBytes()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public static long HostToNetworkOrder(long host)
        {
             throw new NotImplementedException();
        }
        
        
        public static int HostToNetworkOrder(int host)
        {
             throw new NotImplementedException();
        }
        
        
        public static short HostToNetworkOrder(short host)
        {
             throw new NotImplementedException();
        }
        
        
        public static long NetworkToHostOrder(long network)
        {
             throw new NotImplementedException();
        }
        
        
        public static int NetworkToHostOrder(int network)
        {
             throw new NotImplementedException();
        }
        
        
        public static short NetworkToHostOrder(short network)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsLoopback(IPAddress address)
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
        
        
        public IPAddress MapToIPv6()
        {
             throw new NotImplementedException();
        }
        
        
        public IPAddress MapToIPv4()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
