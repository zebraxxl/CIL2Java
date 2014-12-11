
namespace System.Net.NetworkInformation
{
    public abstract class NetworkInterface
    {
        public static int LoopbackInterfaceIndex
        {
            get { throw new NotImplementedException(); }
        }
    
        public static int IPv6LoopbackInterfaceIndex
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Id
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Description
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual OperationalStatus OperationalStatus
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual long Speed
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReceiveOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool SupportsMulticast
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual NetworkInterfaceType NetworkInterfaceType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static NetworkInterface[] GetAllNetworkInterfaces()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool GetIsNetworkAvailable()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IPInterfaceProperties GetIPProperties()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IPv4InterfaceStatistics GetIPv4Statistics()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IPInterfaceStatistics GetIPStatistics()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PhysicalAddress GetPhysicalAddress()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
        {
             throw new NotImplementedException();
        }
        
        
        protected NetworkInterface()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
