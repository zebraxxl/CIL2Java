
namespace System.Net.NetworkInformation
{
    public abstract class IPv4InterfaceProperties
    {
        public abstract bool UsesWins
        {
            get;
        }
    
        public abstract bool IsDhcpEnabled
        {
            get;
        }
    
        public abstract bool IsAutomaticPrivateAddressingActive
        {
            get;
        }
    
        public abstract bool IsAutomaticPrivateAddressingEnabled
        {
            get;
        }
    
        public abstract int Index
        {
            get;
        }
    
        public abstract bool IsForwardingEnabled
        {
            get;
        }
    
        public abstract int Mtu
        {
            get;
        }
    
    
        protected IPv4InterfaceProperties()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
