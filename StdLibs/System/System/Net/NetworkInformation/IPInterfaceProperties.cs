
namespace System.Net.NetworkInformation
{
    public abstract class IPInterfaceProperties
    {
        public abstract bool IsDnsEnabled
        {
            get;
        }
    
        public abstract string DnsSuffix
        {
            get;
        }
    
        public abstract bool IsDynamicDnsEnabled
        {
            get;
        }
    
        public abstract UnicastIPAddressInformationCollection UnicastAddresses
        {
            get;
        }
    
        public abstract MulticastIPAddressInformationCollection MulticastAddresses
        {
            get;
        }
    
        public abstract IPAddressInformationCollection AnycastAddresses
        {
            get;
        }
    
        public abstract IPAddressCollection DnsAddresses
        {
            get;
        }
    
        public abstract GatewayIPAddressInformationCollection GatewayAddresses
        {
            get;
        }
    
        public abstract IPAddressCollection DhcpServerAddresses
        {
            get;
        }
    
        public abstract IPAddressCollection WinsServersAddresses
        {
            get;
        }
    
    
        public abstract IPv4InterfaceProperties GetIPv4Properties();
        
        
        public abstract IPv6InterfaceProperties GetIPv6Properties();
        
        
        protected IPInterfaceProperties()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
